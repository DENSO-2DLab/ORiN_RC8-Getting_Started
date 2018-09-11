using System;
using System.Windows.Forms;
using System.Diagnostics;		// For Process handling
using ORiN2.interop.CAO;		// Provide a path for the code below to the CaoRCW dll that is in the References area of the project

namespace RC8_with_ORiN
{
	// This program connects to an RC8 Controller, reads a variable, writes a variable and disconnects from the RC8 controller
	public partial class Form1 : Form
	{
		// Global Variables

		private CaoEngine ORiN_Engine;
		private CaoController RC8Controller;
		private CaoVariable RC8variable_S10;

		private int incrementValue = 0;

		public Form1()
		{
			// This constructor for the graphical interface is called automatically upon program startup before the form is visible to the user
			InitializeComponent();

			// Disable the buttons to prevent exceptions from the user clicking them out of order
			button_ReadVariable.Enabled = false;
			button_WriteVariable.Enabled = false;
			button_Close.Enabled = false;

			KillCaoExecutableIfItIsAlreadyRunning();	// This is required to prevent lockup in the event that this program is not properly shut down

			ORiN_Engine = new CaoEngine();				// This starts a separate program called "CAO.exe" which allows this program to talk with RC8 controllers
		}

		private static void KillCaoExecutableIfItIsAlreadyRunning()
		{
			// Kill the CAO.exe process in case it wasn't properly shut down last time
			// For example, in case the user ran this code and then aborted it instead of shutting it down normally using the Close/Disconnect method below
			Process[] caoProcesses = Process.GetProcessesByName("CAO");	// Retrieve all processes that have the name "CAO"
			
			if ((caoProcesses != null) && (caoProcesses.Length > 0))	// If there is at least one "CAO" process...
				caoProcesses[0].Kill();	// Kill the first process
		}

		private void button_Connect_Click(object sender, EventArgs e)
		{
			button_Connect.Enabled = false;

			// Create a link to the RC8 controller via the engine (CAO.exe)
			RC8Controller = ORiN_Engine.Workspaces.Item(0).AddController(
								"",						// This is the name of the connection to the RC8 controller; Pass an empty string to have the controller auto-generate a name
								"CaoProv.DENSO.RC8",	// This is the name of the DENSO ORiN provider for RC8; It must be exactly as shown
								"localhost",			// This is the name of the machine executing the DENSO ORiN provider (usually the machine running this program)
								"Server=192.168.0.1");	// This is the IP address of the physical RC8 controller

			// Add a local variable that is linked to string variable S10 on the physical RC8 controller
			RC8variable_S10 = RC8Controller.AddVariable("S10");
			
			button_ReadVariable.Enabled = true;
			button_WriteVariable.Enabled = true;
			button_Close.Enabled = true;
		}

		private void button_ReadVariable_Click(object sender, EventArgs e)
		{
			ReadVariable();
		}

		private void ReadVariable() {
			// Reading from the local variable reads from the remote variable on the RC8 controller
			label_VariableContent.Text = RC8variable_S10.Value.ToString();
		}

		private void button_WriteVariable_Click(object sender, EventArgs e)
		{
			// Writing to the local variable also writes the same content to the remote variable on the RC8 controller
			// Add a digit to the variable, incrementing the digit by one each time the button is pressed
			RC8variable_S10.Value = label_VariableContent.Text + (incrementValue++).ToString();
			ReadVariable();
		}

		private void button_Close_Click(object sender, EventArgs e)
		{
			// Properly shut down the local variables in reverse order of precedence so that the ORiN engine is not left hanging
			RC8Controller.Variables.Clear();	// Clear all local variables from the controller variable (THIS DOES NOT AFFECT VALUES ON THE PHYSICAL RC8 CONTROLLER)
			RC8variable_S10 = null;				// Set the individual local variables to null

			ORiN_Engine.Workspaces.Item(0).Controllers.Remove(RC8Controller.Index);	// Remove the controller variable from the ORiN engine
			RC8Controller = null;				// Set the individual controller variable to null

			ORiN_Engine = null;					// Set the ORiN engine variable to null

			Close();							// Exit this C# program
		}
	}
}