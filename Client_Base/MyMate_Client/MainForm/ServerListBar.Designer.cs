namespace MainForm
{
	partial class ServerListBar
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SideBarPanel1 = new System.Windows.Forms.Panel();
			this.cButton1 = new Controls.CButton();
			this.SideBarPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SideBarPanel1
			// 
			this.SideBarPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
			this.SideBarPanel1.Controls.Add(this.cButton1);
			this.SideBarPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SideBarPanel1.Location = new System.Drawing.Point(0, 0);
			this.SideBarPanel1.Name = "SideBarPanel1";
			this.SideBarPanel1.Size = new System.Drawing.Size(50, 400);
			this.SideBarPanel1.TabIndex = 7;
			this.SideBarPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.SideBarPanel1_Paint);
			// 
			// cButton1
			// 
			this.cButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.cButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
			this.cButton1.BorderColor = System.Drawing.Color.Red;
			this.cButton1.BorderRadius = 25;
			this.cButton1.BorderSize = 0;
			this.cButton1.FlatAppearance.BorderSize = 0;
			this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cButton1.ForeColor = System.Drawing.Color.White;
			this.cButton1.Location = new System.Drawing.Point(0, 0);
			this.cButton1.Name = "cButton1";
			this.cButton1.Size = new System.Drawing.Size(50, 51);
			this.cButton1.TabIndex = 0;
			this.cButton1.Text = "cButton1";
			this.cButton1.TextColor = System.Drawing.Color.White;
			this.cButton1.UseVisualStyleBackColor = false;
			this.cButton1.Click += new System.EventHandler(this.cButton1_Click);
			// 
			// ServerListBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(50, 400);
			this.Controls.Add(this.SideBarPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ServerListBar";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "ServerListBar";
			this.Load += new System.EventHandler(this.ServerListBar_Load);
			this.SideBarPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel SideBarPanel1;
		private Controls.CButton cButton1;
	}
}