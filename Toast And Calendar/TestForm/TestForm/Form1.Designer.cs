namespace TestForm
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSend = new System.Windows.Forms.Button();
			this.btnUseerMessage = new System.Windows.Forms.Button();
			this.btnSystemMessage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(103, 98);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(252, 218);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// btnUseerMessage
			// 
			this.btnUseerMessage.Location = new System.Drawing.Point(399, 121);
			this.btnUseerMessage.Name = "btnUseerMessage";
			this.btnUseerMessage.Size = new System.Drawing.Size(252, 61);
			this.btnUseerMessage.TabIndex = 0;
			this.btnUseerMessage.Text = "UserMessage";
			this.btnUseerMessage.UseVisualStyleBackColor = true;
			this.btnUseerMessage.Click += new System.EventHandler(this.btnUserMessage_Click);
			// 
			// btnSystemMessage
			// 
			this.btnSystemMessage.Location = new System.Drawing.Point(399, 201);
			this.btnSystemMessage.Name = "btnSystemMessage";
			this.btnSystemMessage.Size = new System.Drawing.Size(252, 61);
			this.btnSystemMessage.TabIndex = 0;
			this.btnSystemMessage.Text = "SystemMessage";
			this.btnSystemMessage.UseVisualStyleBackColor = true;
			this.btnSystemMessage.Click += new System.EventHandler(this.SystemMessage_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSystemMessage);
			this.Controls.Add(this.btnUseerMessage);
			this.Controls.Add(this.btnSend);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private Button btnSend;
		private Button btnUseerMessage;
		private Button btnSystemMessage;
	}
}