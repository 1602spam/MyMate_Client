namespace MainForm.Controls
{
    partial class UserProfilePopup
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.roundButton1 = new MainForm.Controls.RoundButton();
            this.rtbIntroduction = new System.Windows.Forms.RichTextBox();
            this.btnChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.closeBtn.Location = new System.Drawing.Point(248, -1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(22, 23);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 145);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(82, 15);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "TextUsername";
            this.lblUserName.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 169);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail : ";
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Location = new System.Drawing.Point(12, 193);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(84, 15);
            this.lblIntroduction.TabIndex = 4;
            this.lblIntroduction.Text = "Introduction : ";
            this.lblIntroduction.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "이름";
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton1.BorderColor = System.Drawing.Color.Red;
            this.roundButton1.BorderRadius = 40;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(94, 27);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(80, 80);
            this.roundButton1.TabIndex = 6;
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // rtbIntroduction
            // 
            this.rtbIntroduction.Location = new System.Drawing.Point(12, 218);
            this.rtbIntroduction.Name = "rtbIntroduction";
            this.rtbIntroduction.ReadOnly = true;
            this.rtbIntroduction.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbIntroduction.Size = new System.Drawing.Size(246, 81);
            this.rtbIntroduction.TabIndex = 7;
            this.rtbIntroduction.Text = "";
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(85, 312);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(98, 25);
            this.btnChat.TabIndex = 8;
            this.btnChat.Text = "채팅 바로가기";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserProfilePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(270, 350);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.rtbIntroduction);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblIntroduction);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfilePopup";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.UserProfilePopup_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Profile_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Profile_MouseMove);
            this.Move += new System.EventHandler(this.Profile_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button closeBtn;
        private Label lblUserName;
        private Label lblEmail;
        private Label lblIntroduction;
        private Label lblName;
        private RoundButton roundButton1;
        private RichTextBox rtbIntroduction;
        private Button btnChat;
    }
}