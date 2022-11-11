namespace MainForm.Controls
{
    partial class FriendPageItem
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtnProfile = new MainForm.Controls.RoundButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.rbtnChat = new MainForm.Controls.RoundButton();
            this.SuspendLayout();
            // 
            // rbtnProfile
            // 
            this.rbtnProfile.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnProfile.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnProfile.BorderColor = System.Drawing.Color.Red;
            this.rbtnProfile.BorderRadius = 25;
            this.rbtnProfile.BorderSize = 0;
            this.rbtnProfile.FlatAppearance.BorderSize = 0;
            this.rbtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnProfile.ForeColor = System.Drawing.Color.White;
            this.rbtnProfile.Location = new System.Drawing.Point(18, 5);
            this.rbtnProfile.Name = "rbtnProfile";
            this.rbtnProfile.Size = new System.Drawing.Size(50, 50);
            this.rbtnProfile.TabIndex = 0;
            this.rbtnProfile.TextColor = System.Drawing.Color.White;
            this.rbtnProfile.UseVisualStyleBackColor = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(86, 23);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(31, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "뭘봐";
            // 
            // rbtnChat
            // 
            this.rbtnChat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnChat.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnChat.BorderColor = System.Drawing.Color.Red;
            this.rbtnChat.BorderRadius = 2;
            this.rbtnChat.BorderSize = 0;
            this.rbtnChat.FlatAppearance.BorderSize = 0;
            this.rbtnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnChat.ForeColor = System.Drawing.Color.White;
            this.rbtnChat.Location = new System.Drawing.Point(346, 10);
            this.rbtnChat.Name = "rbtnChat";
            this.rbtnChat.Size = new System.Drawing.Size(150, 40);
            this.rbtnChat.TabIndex = 2;
            this.rbtnChat.Text = "채팅 바로가기";
            this.rbtnChat.TextColor = System.Drawing.Color.White;
            this.rbtnChat.UseVisualStyleBackColor = false;
            // 
            // FriendPageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbtnChat);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.rbtnProfile);
            this.Name = "FriendPageItem";
            this.Size = new System.Drawing.Size(519, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton rbtnProfile;
        private Label lblUsername;
        private RoundButton rbtnChat;
    }
}
