namespace RC8_with_ORiN_Intermediate {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_WriteVariable = new System.Windows.Forms.Button();
            this.label_VariableContent = new System.Windows.Forms.Label();
            this.button_TurnOnMotors = new System.Windows.Forms.Button();
            this.button_TurnOffMotors = new System.Windows.Forms.Button();
            this.button_HaltMotion = new System.Windows.Forms.Button();
            this.button_StartMotion = new System.Windows.Forms.Button();
            this.timer_InterfaceUpdate = new System.Windows.Forms.Timer(this.components);
            this.groupBoxCurrentPosition = new System.Windows.Forms.GroupBox();
            this.propertyGrid_CurrentPosition = new System.Windows.Forms.PropertyGrid();
            this.groupBoxCurrentAngle = new System.Windows.Forms.GroupBox();
            this.propertyGrid_CurrentAngle = new System.Windows.Forms.PropertyGrid();
            this.trackBar_Speed = new System.Windows.Forms.TrackBar();
            this.label_SpeedValue = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.button_ClearError = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_WriteVariable = new System.Windows.Forms.GroupBox();
            this.textBox_ContentToWrite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownChangeWork = new System.Windows.Forms.NumericUpDown();
            this.labelChangeTool = new System.Windows.Forms.Label();
            this.numericUpDownChangeTool = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ErrorInfo = new System.Windows.Forms.Label();
            this.groupBoxCurrentPosition.SuspendLayout();
            this.groupBoxCurrentAngle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).BeginInit();
            this.groupBox_WriteVariable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChangeWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChangeTool)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(35, 24);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 0;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_WriteVariable
            // 
            this.button_WriteVariable.Location = new System.Drawing.Point(0, 56);
            this.button_WriteVariable.Name = "button_WriteVariable";
            this.button_WriteVariable.Size = new System.Drawing.Size(213, 23);
            this.button_WriteVariable.TabIndex = 3;
            this.button_WriteVariable.Text = "Write Variable";
            this.button_WriteVariable.UseVisualStyleBackColor = true;
            this.button_WriteVariable.Click += new System.EventHandler(this.button_WriteVariable_Click);
            // 
            // label_VariableContent
            // 
            this.label_VariableContent.AutoSize = true;
            this.label_VariableContent.Location = new System.Drawing.Point(100, 16);
            this.label_VariableContent.Name = "label_VariableContent";
            this.label_VariableContent.Size = new System.Drawing.Size(53, 13);
            this.label_VariableContent.TabIndex = 4;
            this.label_VariableContent.Text = "Unknown";
            // 
            // button_TurnOnMotors
            // 
            this.button_TurnOnMotors.Location = new System.Drawing.Point(128, 24);
            this.button_TurnOnMotors.Name = "button_TurnOnMotors";
            this.button_TurnOnMotors.Size = new System.Drawing.Size(100, 23);
            this.button_TurnOnMotors.TabIndex = 6;
            this.button_TurnOnMotors.Text = "Turn On Motors";
            this.button_TurnOnMotors.UseVisualStyleBackColor = true;
            this.button_TurnOnMotors.Click += new System.EventHandler(this.button_TurnOnMotors_Click);
            // 
            // button_TurnOffMotors
            // 
            this.button_TurnOffMotors.Location = new System.Drawing.Point(128, 53);
            this.button_TurnOffMotors.Name = "button_TurnOffMotors";
            this.button_TurnOffMotors.Size = new System.Drawing.Size(100, 23);
            this.button_TurnOffMotors.TabIndex = 7;
            this.button_TurnOffMotors.Text = "Turn Off Motors";
            this.button_TurnOffMotors.UseVisualStyleBackColor = true;
            this.button_TurnOffMotors.Click += new System.EventHandler(this.button_TurnOffMotors_Click);
            // 
            // button_HaltMotion
            // 
            this.button_HaltMotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_HaltMotion.ForeColor = System.Drawing.Color.Red;
            this.button_HaltMotion.Location = new System.Drawing.Point(600, 102);
            this.button_HaltMotion.Name = "button_HaltMotion";
            this.button_HaltMotion.Size = new System.Drawing.Size(172, 142);
            this.button_HaltMotion.TabIndex = 8;
            this.button_HaltMotion.Text = "HALT MOTION";
            this.button_HaltMotion.UseVisualStyleBackColor = true;
            this.button_HaltMotion.Click += new System.EventHandler(this.button_HaltMotion_Click);
            // 
            // button_StartMotion
            // 
            this.button_StartMotion.Location = new System.Drawing.Point(600, 34);
            this.button_StartMotion.Name = "button_StartMotion";
            this.button_StartMotion.Size = new System.Drawing.Size(172, 46);
            this.button_StartMotion.TabIndex = 9;
            this.button_StartMotion.Text = "Move to Next Position";
            this.button_StartMotion.UseVisualStyleBackColor = true;
            this.button_StartMotion.Click += new System.EventHandler(this.button_StartMotion_Click);
            // 
            // timer_InterfaceUpdate
            // 
            this.timer_InterfaceUpdate.Tick += new System.EventHandler(this.timer_InterfaceUpdate_Tick);
            // 
            // groupBoxCurrentPosition
            // 
            this.groupBoxCurrentPosition.Controls.Add(this.propertyGrid_CurrentPosition);
            this.groupBoxCurrentPosition.Location = new System.Drawing.Point(353, 86);
            this.groupBoxCurrentPosition.Name = "groupBoxCurrentPosition";
            this.groupBoxCurrentPosition.Size = new System.Drawing.Size(222, 161);
            this.groupBoxCurrentPosition.TabIndex = 43;
            this.groupBoxCurrentPosition.TabStop = false;
            this.groupBoxCurrentPosition.Text = "Current Position";
            this.groupBoxCurrentPosition.Enter += new System.EventHandler(this.groupBoxCurrentPosition_Enter);
            // 
            // propertyGrid_CurrentPosition
            // 
            this.propertyGrid_CurrentPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid_CurrentPosition.HelpVisible = false;
            this.propertyGrid_CurrentPosition.Location = new System.Drawing.Point(3, 16);
            this.propertyGrid_CurrentPosition.Name = "propertyGrid_CurrentPosition";
            this.propertyGrid_CurrentPosition.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.propertyGrid_CurrentPosition.Size = new System.Drawing.Size(216, 142);
            this.propertyGrid_CurrentPosition.TabIndex = 35;
            this.propertyGrid_CurrentPosition.ToolbarVisible = false;
            // 
            // groupBoxCurrentAngle
            // 
            this.groupBoxCurrentAngle.Controls.Add(this.propertyGrid_CurrentAngle);
            this.groupBoxCurrentAngle.Location = new System.Drawing.Point(125, 86);
            this.groupBoxCurrentAngle.Name = "groupBoxCurrentAngle";
            this.groupBoxCurrentAngle.Size = new System.Drawing.Size(222, 161);
            this.groupBoxCurrentAngle.TabIndex = 42;
            this.groupBoxCurrentAngle.TabStop = false;
            this.groupBoxCurrentAngle.Text = "Current Angle";
            // 
            // propertyGrid_CurrentAngle
            // 
            this.propertyGrid_CurrentAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid_CurrentAngle.HelpVisible = false;
            this.propertyGrid_CurrentAngle.Location = new System.Drawing.Point(3, 16);
            this.propertyGrid_CurrentAngle.Name = "propertyGrid_CurrentAngle";
            this.propertyGrid_CurrentAngle.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.propertyGrid_CurrentAngle.Size = new System.Drawing.Size(216, 142);
            this.propertyGrid_CurrentAngle.TabIndex = 35;
            this.propertyGrid_CurrentAngle.ToolbarVisible = false;
            // 
            // trackBar_Speed
            // 
            this.trackBar_Speed.AutoSize = false;
            this.trackBar_Speed.Location = new System.Drawing.Point(448, 44);
            this.trackBar_Speed.Maximum = 100;
            this.trackBar_Speed.Minimum = 1;
            this.trackBar_Speed.Name = "trackBar_Speed";
            this.trackBar_Speed.Size = new System.Drawing.Size(124, 36);
            this.trackBar_Speed.TabIndex = 48;
            this.trackBar_Speed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Speed.Value = 10;
            this.trackBar_Speed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // label_SpeedValue
            // 
            this.label_SpeedValue.AutoSize = true;
            this.label_SpeedValue.Location = new System.Drawing.Point(515, 24);
            this.label_SpeedValue.Name = "label_SpeedValue";
            this.label_SpeedValue.Size = new System.Drawing.Size(29, 13);
            this.label_SpeedValue.TabIndex = 47;
            this.label_SpeedValue.Text = "Zero";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(459, 24);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(56, 13);
            this.labelSpeed.TabIndex = 46;
            this.labelSpeed.Text = "ExtSpeed:";
            // 
            // button_ClearError
            // 
            this.button_ClearError.Location = new System.Drawing.Point(16, 309);
            this.button_ClearError.Name = "button_ClearError";
            this.button_ClearError.Size = new System.Drawing.Size(94, 23);
            this.button_ClearError.TabIndex = 49;
            this.button_ClearError.Text = "Clear Error";
            this.button_ClearError.UseVisualStyleBackColor = true;
            this.button_ClearError.Click += new System.EventHandler(this.button_ClearError_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Variable Content:";
            // 
            // groupBox_WriteVariable
            // 
            this.groupBox_WriteVariable.Controls.Add(this.label4);
            this.groupBox_WriteVariable.Controls.Add(this.textBox_ContentToWrite);
            this.groupBox_WriteVariable.Controls.Add(this.label3);
            this.groupBox_WriteVariable.Controls.Add(this.label_VariableContent);
            this.groupBox_WriteVariable.Controls.Add(this.button_WriteVariable);
            this.groupBox_WriteVariable.Location = new System.Drawing.Point(356, 253);
            this.groupBox_WriteVariable.Name = "groupBox_WriteVariable";
            this.groupBox_WriteVariable.Size = new System.Drawing.Size(216, 87);
            this.groupBox_WriteVariable.TabIndex = 51;
            this.groupBox_WriteVariable.TabStop = false;
            this.groupBox_WriteVariable.Text = "Variable S10";
            // 
            // textBox_ContentToWrite
            // 
            this.textBox_ContentToWrite.Location = new System.Drawing.Point(103, 31);
            this.textBox_ContentToWrite.Name = "textBox_ContentToWrite";
            this.textBox_ContentToWrite.Size = new System.Drawing.Size(107, 20);
            this.textBox_ContentToWrite.TabIndex = 10;
            this.textBox_ContentToWrite.Text = "99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Content To Write:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Change Work";
            // 
            // numericUpDownChangeWork
            // 
            this.numericUpDownChangeWork.Location = new System.Drawing.Point(256, 44);
            this.numericUpDownChangeWork.Name = "numericUpDownChangeWork";
            this.numericUpDownChangeWork.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownChangeWork.TabIndex = 52;
            this.numericUpDownChangeWork.ValueChanged += new System.EventHandler(this.numericUpDownChangeWork_ValueChanged);
            // 
            // labelChangeTool
            // 
            this.labelChangeTool.AutoSize = true;
            this.labelChangeTool.Location = new System.Drawing.Point(356, 28);
            this.labelChangeTool.Name = "labelChangeTool";
            this.labelChangeTool.Size = new System.Drawing.Size(68, 13);
            this.labelChangeTool.TabIndex = 55;
            this.labelChangeTool.Text = "Change Tool";
            // 
            // numericUpDownChangeTool
            // 
            this.numericUpDownChangeTool.Location = new System.Drawing.Point(359, 44);
            this.numericUpDownChangeTool.Name = "numericUpDownChangeTool";
            this.numericUpDownChangeTool.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownChangeTool.TabIndex = 54;
            this.numericUpDownChangeTool.ValueChanged += new System.EventHandler(this.numericUpDownChangeTool_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Error Information:";
            // 
            // label_ErrorInfo
            // 
            this.label_ErrorInfo.AutoSize = true;
            this.label_ErrorInfo.Location = new System.Drawing.Point(116, 342);
            this.label_ErrorInfo.Name = "label_ErrorInfo";
            this.label_ErrorInfo.Size = new System.Drawing.Size(53, 13);
            this.label_ErrorInfo.TabIndex = 56;
            this.label_ErrorInfo.Text = "Unknown";
            this.label_ErrorInfo.Click += new System.EventHandler(this.label_ErrorInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_ErrorInfo);
            this.Controls.Add(this.labelChangeTool);
            this.Controls.Add(this.numericUpDownChangeTool);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownChangeWork);
            this.Controls.Add(this.groupBox_WriteVariable);
            this.Controls.Add(this.button_ClearError);
            this.Controls.Add(this.trackBar_Speed);
            this.Controls.Add(this.label_SpeedValue);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.groupBoxCurrentPosition);
            this.Controls.Add(this.groupBoxCurrentAngle);
            this.Controls.Add(this.button_StartMotion);
            this.Controls.Add(this.button_HaltMotion);
            this.Controls.Add(this.button_TurnOffMotors);
            this.Controls.Add(this.button_TurnOnMotors);
            this.Controls.Add(this.button_Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBoxCurrentPosition.ResumeLayout(false);
            this.groupBoxCurrentAngle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).EndInit();
            this.groupBox_WriteVariable.ResumeLayout(false);
            this.groupBox_WriteVariable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChangeWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChangeTool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_Connect;
		private System.Windows.Forms.Button button_WriteVariable;
		private System.Windows.Forms.Label label_VariableContent;
		private System.Windows.Forms.Button button_TurnOnMotors;
		private System.Windows.Forms.Button button_TurnOffMotors;
		private System.Windows.Forms.Button button_HaltMotion;
		private System.Windows.Forms.Button button_StartMotion;
		private System.Windows.Forms.Timer timer_InterfaceUpdate;
		private System.Windows.Forms.GroupBox groupBoxCurrentPosition;
		protected System.Windows.Forms.PropertyGrid propertyGrid_CurrentPosition;
		private System.Windows.Forms.GroupBox groupBoxCurrentAngle;
		protected System.Windows.Forms.PropertyGrid propertyGrid_CurrentAngle;
		private System.Windows.Forms.TrackBar trackBar_Speed;
		private System.Windows.Forms.Label label_SpeedValue;
		private System.Windows.Forms.Label labelSpeed;
		private System.Windows.Forms.Button button_ClearError;
		private System.Windows.Forms.GroupBox groupBox_WriteVariable;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_ContentToWrite;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDownChangeWork;
		private System.Windows.Forms.Label labelChangeTool;
		private System.Windows.Forms.NumericUpDown numericUpDownChangeTool;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label_ErrorInfo;
	}
}

