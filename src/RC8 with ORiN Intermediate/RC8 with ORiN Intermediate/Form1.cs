using System;
using System.Windows.Forms;
using System.Diagnostics;		// For Process handling
using System.Collections.Generic;	// For List
using ORiN2.interop.CAO;		// Provide a path for the code below to the CaoRCW dll that is in the References area of the project

namespace RC8_with_ORiN_Intermediate
{
	// This program connects to an RC8 Controller, reads a variable, writes a variable and disconnects from the RC8 controller
	public partial class Form1 : Form
	{
		// Global Variables

		private CaoEngine ORiN_Engine;
		private CaoController RC8Controller;
		
		// Robot Variables
		private CaoRobot Robot;							// See the "RC8 Provider for DENSO Robot RC8 User's Guide" for more information on Robot.Execute() commands
		private CaoVariable RobotBusyStatus;
		private CaoVariable RobotState;
		private CaoVariable RobotExternalSpeed;
		private CaoVariable RobotCurrentPosition;
		private CaoVariable RobotCurrentAngle;
		
		// Controller Variables
		private CaoVariable CurrentErrorCode;
		private CaoVariable CurrentErrorDescription;
		private CaoVariable RC8variable_S10;

		// Helper Variables
		private List<string> positionList = new List<string>();		// List of robot positions
		private int currentPositionNumber = 0;						// Variable to hold the number of the current robot desitnation position
		private string errorInstruction = Environment.NewLine + Environment.NewLine + "1) Review the Error Information" + Environment.NewLine + "2) Clear the error" + Environment.NewLine + "3) Correct the error";

		#region Initialization and Connection

		public Form1()
		{
			// This constructor for the graphical interface is called automatically upon program startup before the form is visible to the user
			InitializeComponent();
		}

		private void button_Connect_Click(object sender, EventArgs e) {
			ConnectToController();
			InitVariables();
			InitPositions();
			try {
				Robot.Execute("ForceTakeArm");		// Forcefully take control of the robot arm (even if another program is controlling it)
			} catch (Exception ex) {
				ShowError("ForceTakeArm", ex);
			}
		}

		private void ConnectToController() {

			KillCaoExecutableIfItIsAlreadyRunning();	// This is required to prevent lockup in the event that this program is not properly shut down

			ORiN_Engine = new CaoEngine();				// This starts a separate program called "CAO.exe" which allows this program to talk with RC8 controllers

			// Create a link to the RC8 controller via the engine (CAO.exe)
			RC8Controller = ORiN_Engine.Workspaces.Item(0).AddController(
								"",						// This is the name of the connection to the RC8 controller; Pass an empty string to have the controller auto-generate a name
								"CaoProv.DENSO.RC8",	// This is the name of the DENSO ORiN provider for RC8; It must be exactly as shown
								"localhost",			// This is the name of the machine executing the DENSO ORiN provider (usually the machine running this program)
								"Server=192.168.0.1");	// This is the IP address of the physical RC8 controller
		}

		private void InitVariables() {
			// Add local variables that are linked to corresponding variables on the physical RC8 controller
			// Add a variable linked to the robot connected to the RC8 controller
			Robot = RC8Controller.AddRobot("Arm");

			// Add robot variables
			RobotBusyStatus = Robot.AddVariable("@BUSY_STATUS");				// Add a variable linked to the robot's busy status

			RobotState = Robot.AddVariable("@State");							// Add a variable which contains the current state of the robot
			RobotExternalSpeed = Robot.AddVariable("@Extspeed");				// Add a variable linked to the external (teach pendant) speed
			RobotCurrentPosition = Robot.AddVariable("@CURRENT_POSITION");		// Add a variable which contains the current robot position
			RobotCurrentAngle = Robot.AddVariable("@CURRENT_ANGLE");			// Add a variable which contains the current robot angle			

			// Add variables that are linked to the current error code and description
			CurrentErrorCode = RC8Controller.AddVariable("@ERROR_CODE");
			CurrentErrorDescription = RC8Controller.AddVariable("@ERROR_DESCRIPTION");

			// Register to handle new message events from the controller
			// Every time the controller has a new message, the ShowMessage function will be called
			RC8Controller.OnMessage += new _ICaoControllerEvents_OnMessageEventHandler(ShowMessage);

			// Add a variable linked to string variable S10 
			RC8variable_S10 = RC8Controller.AddVariable("S10");

			timer_InterfaceUpdate.Start();	// Start the GUI timer
		}

		private void InitPositions() {
			// Add two positions to the position list
			positionList.Add("@P P(350,  100, 220, 180, 0, 180, 5)");
			positionList.Add("@P P(350, -200, 220, 180, 0, 180, 5)");
		}

		private static void KillCaoExecutableIfItIsAlreadyRunning() {
			// Kill the CAO.exe process in case it wasn't properly shut down last time
			// For example, in case the user ran this code and then aborted it instead of shutting it down normally using 
			// the Close/Disconnect method below
			Process[] caoProcesses = Process.GetProcessesByName("CAO");	// Retrieve all processes that have the name "CAO"

			if ((caoProcesses != null) && (caoProcesses.Length > 0))	// If there is at least one "CAO" process...
				caoProcesses[0].Kill();	// Kill the first process
		}

		private void ShowMessage(CaoMessage message) {
			string errorInfo = message.DateTime.ToString();
			errorInfo += " Number:" + message.Number.ToString();
			errorInfo += " Value:" + message.Value.ToString();
			errorInfo += " Destination:" + message.Destination.ToString();
			errorInfo += " Decription:" + message.Description.ToString();
			errorInfo += " Description2:" + CurrentErrorDescription.Value.ToString();

			// Use the Invoke command to update the user interface since this function is not called from the User Interface (UI) thread
			this.Invoke((MethodInvoker)delegate {
				label_ErrorInfo.Text = errorInfo;
			});
		}

		#endregion

		#region Disconnection and Exiting the Program

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			Disconnect();
		}

		private void Disconnect() {
			// Properly shut down the local variables in reverse order of precedence so that the ORiN engine is not left hanging
			TurnOffMotors();

			try {
				Robot.Execute("GiveArm");		// Release the arm
			} catch (Exception ex) {
				ShowError("GiveArm", ex);
			}

			Robot.Variables.Clear();			// Clear all robot-specific variables from the main robot variable (THIS DOES NOT AFFECT VALUES ON THE PHYSICAL RC8 CONTROLLER)
			RobotBusyStatus = null;				// Set the individual robot-specific variable to null
			RobotState = null;
			RobotExternalSpeed = null;
			RobotCurrentPosition = null;
			RobotCurrentAngle = null;

			RC8Controller.Robots.Clear();		// Clear all local robot variables from the controller variable
			Robot = null;						// Set the individual robot variable to null

			RC8Controller.Variables.Clear();	// Clear all local variables from the controller variable (THIS DOES NOT AFFECT VALUES ON THE PHYSICAL RC8 CONTROLLER)
			CurrentErrorCode = null;			// Set the individual local variables to null
			CurrentErrorDescription = null;
			RC8variable_S10 = null;

			ORiN_Engine.Workspaces.Item(0).Controllers.Remove(RC8Controller.Index);	// Remove the controller variable from the ORiN engine
			RC8Controller = null;				// Set the individual controller variable to null

			ORiN_Engine = null;					// Set the ORiN engine variable to null
		}

		#endregion

		#region GUI Button Handlers

		private void button_TurnOnMotors_Click(object sender, EventArgs e) {
			if (RobotIsNotBusy()) {
				try {
					Robot.Execute("Motor", new object[] { 1 });		// Execute the "Motor" command and pass it a '1' which signifies that the motors should turn on
				} catch (Exception ex) {
					ShowError("Motor On", ex);
				}
			}
		}

		private void button_TurnOffMotors_Click(object sender, EventArgs e) {
			TurnOffMotors();
		}

		private void button_HaltMotion_Click(object sender, EventArgs e) {
			try {
				Robot.Halt();	// Tell the controller to halt all robot motion immediately 
			} catch (Exception ex) {
				ShowError("Halt", ex);
			}
		}

		private void button_StartMotion_Click(object sender, EventArgs e) {
			if (RobotIsNotBusy()) {
				SetCurrentPosition();
				try{
					// Move to the position at index "currentPositionNumber" using a point to point (CP) move (1)
					// The "NEXT" argument specifies that the function should return without waiting for motion to be completed
					Robot.Move(1, positionList[currentPositionNumber], "NEXT");
				} catch (Exception ex) {
					ShowError("Move", ex);
				}
			}
		}

		private void timer_InterfaceUpdate_Tick(object sender, EventArgs e) {
			// This function is called every time the timer object (located at the bottom of the Form1 designer) times out

			double[] positionArray = RobotCurrentPosition.Value;						// Get the current robot position
			double[] angleArray = RobotCurrentAngle.Value;								// Get the current robot angle

			// Round the values to the closest micron/degree for ease of readability
			for (int i = 0; i < positionArray.Length; i++) {
				positionArray[i] = Math.Round(positionArray[i], 3);
			}

			for (int i = 0; i < angleArray.Length; i++) {
				angleArray[i] = Math.Round(angleArray[i], 3);
			}

			// Update the interface controls with the latest information
			propertyGrid_CurrentPosition.SelectedObject = positionArray;				// Show the cleaned-up current robot position
			propertyGrid_CurrentAngle.SelectedObject = angleArray;						// Show the cleaned-up current robot angle
			label_SpeedValue.Text = RobotExternalSpeed.Value.ToString();				// Show the current robot speed
			trackBar_Speed.Value = (int)RobotExternalSpeed.Value;						// Update the trackbar to reflect the current robot speed
			label_VariableContent.Text = RC8variable_S10.Value.ToString();				// Show the current value of variable S10
			//Console.WriteLine("RobotState: " + RobotState.Value.ToString());
		}

		private void numericUpDownChangeWork_ValueChanged(object sender, EventArgs e) {
			int maxWorkNumber = 7;
			if (numericUpDownChangeWork.Value > maxWorkNumber)
				numericUpDownChangeWork.Value = maxWorkNumber;

			try {
				Robot.Change(string.Format("WORK{0}", numericUpDownChangeWork.Value));	// Change the Work Offset
			} catch (Exception ex) {
				ShowError("Change WORK", ex);
			}
		}

		private void numericUpDownChangeTool_ValueChanged(object sender, EventArgs e) {
			int maxToolNumber = 49;
			if (numericUpDownChangeTool.Value > maxToolNumber)
				numericUpDownChangeTool.Value = maxToolNumber;
			try {
				Robot.Change(string.Format("TOOL{0}", numericUpDownChangeTool.Value));	// Change the Tool Offset
			} catch (Exception ex) {
				ShowError("Change TOOL", ex);
			}
		}

		private void trackBarSpeed_Scroll(object sender, EventArgs e) {
			try {
				RobotExternalSpeed.Value = trackBar_Speed.Value;
			} catch (Exception ex) {
				ShowError("Write to External Speed", ex);
			}
		}

		private void button_ClearError_Click(object sender, EventArgs e) {
			try {
				RC8Controller.Execute("ClearError", CurrentErrorCode.Value);
			} catch (Exception ex) {
				ShowError("ClearError", ex);
			}
		}

		private void button_WriteVariable_Click(object sender, EventArgs e) {
			try {
				// Writing to the local variable also writes the same content to the remote variable on the RC8 controller
				RC8variable_S10.Value = textBox_ContentToWrite.Text;
			} catch (Exception ex) {
				ShowError("Write to Variable", ex);
			}
		}

		#endregion

		#region Helper Functions

		private void TurnOffMotors() {
			if (RobotIsNotBusy()) {
				try {
					Robot.Execute("Motor", new object[] { 0 });		// Execute the "Motor" command and pass it a '0' which signifies that the motors should turn off
				} catch (Exception ex) {
					ShowError("Motor Off", ex);
				}
			}
		}

		private bool RobotIsNotBusy() {
			try {
				return ((bool)RobotBusyStatus.Value == false);	// If the robot is not busy, return true
			} catch (Exception ex) {
				ShowError("RobotBusyStatus", ex);
			}

			return false;			
		}

		private void ShowError(string commandName, Exception currentException){
			MessageBox.Show("Error executing '" + commandName + "' command: " + currentException.Message + errorInstruction);
		}

		private void SetCurrentPosition() {
			currentPositionNumber++;	// Increment the current position by one

			// Get the index of the final position in the list
			int finalPositionNumber = positionList.Count - 1;	// Subtract one since C# indexing starts at zero (e.g., 0, 1, 2, etc)

			// If the current position is greater than the final position, reset the current position to the first position (zero)
			if (currentPositionNumber > finalPositionNumber)
				currentPositionNumber = 0;
		}

		#endregion

        private void groupBoxCurrentPosition_Enter(object sender, EventArgs e)
        {

        }

        private void label_ErrorInfo_Click(object sender, EventArgs e)
        {

        }
	}
}