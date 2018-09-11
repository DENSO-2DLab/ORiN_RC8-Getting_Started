namespace RC8_with_ORiN {
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
			this.button_Connect = new System.Windows.Forms.Button();
			this.button_Close = new System.Windows.Forms.Button();
			this.button_ReadVariable = new System.Windows.Forms.Button();
			this.button_WriteVariable = new System.Windows.Forms.Button();
			this.label_VariableContent = new System.Windows.Forms.Label();
			this.label_Tag = new System.Windows.Forms.Label();
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
			// button_Close
			// 
			this.button_Close.Location = new System.Drawing.Point(35, 175);
			this.button_Close.Name = "button_Close";
			this.button_Close.Size = new System.Drawing.Size(75, 23);
			this.button_Close.TabIndex = 1;
			this.button_Close.Text = "Close";
			this.button_Close.UseVisualStyleBackColor = true;
			this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
			// 
			// button_ReadVariable
			// 
			this.button_ReadVariable.Location = new System.Drawing.Point(35, 79);
			this.button_ReadVariable.Name = "button_ReadVariable";
			this.button_ReadVariable.Size = new System.Drawing.Size(108, 23);
			this.button_ReadVariable.TabIndex = 2;
			this.button_ReadVariable.Text = "Read Variable S10";
			this.button_ReadVariable.UseVisualStyleBackColor = true;
			this.button_ReadVariable.Click += new System.EventHandler(this.button_ReadVariable_Click);
			// 
			// button_WriteVariable
			// 
			this.button_WriteVariable.Location = new System.Drawing.Point(35, 119);
			this.button_WriteVariable.Name = "button_WriteVariable";
			this.button_WriteVariable.Size = new System.Drawing.Size(108, 23);
			this.button_WriteVariable.TabIndex = 3;
			this.button_WriteVariable.Text = "Write Variable S10";
			this.button_WriteVariable.UseVisualStyleBackColor = true;
			this.button_WriteVariable.Click += new System.EventHandler(this.button_WriteVariable_Click);
			// 
			// label_VariableContent
			// 
			this.label_VariableContent.AutoSize = true;
			this.label_VariableContent.Location = new System.Drawing.Point(155, 84);
			this.label_VariableContent.Name = "label_VariableContent";
			this.label_VariableContent.Size = new System.Drawing.Size(53, 13);
			this.label_VariableContent.TabIndex = 4;
			this.label_VariableContent.Text = "Unknown";
			// 
			// label_Tag
			// 
			this.label_Tag.AutoSize = true;
			this.label_Tag.Location = new System.Drawing.Point(155, 61);
			this.label_Tag.Name = "label_Tag";
			this.label_Tag.Size = new System.Drawing.Size(119, 13);
			this.label_Tag.TabIndex = 5;
			this.label_Tag.Text = "Content of Variable S10";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 227);
			this.Controls.Add(this.label_Tag);
			this.Controls.Add(this.label_VariableContent);
			this.Controls.Add(this.button_WriteVariable);
			this.Controls.Add(this.button_ReadVariable);
			this.Controls.Add(this.button_Close);
			this.Controls.Add(this.button_Connect);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_Connect;
		private System.Windows.Forms.Button button_Close;
		private System.Windows.Forms.Button button_ReadVariable;
		private System.Windows.Forms.Button button_WriteVariable;
		private System.Windows.Forms.Label label_VariableContent;
		private System.Windows.Forms.Label label_Tag;
	}
}

