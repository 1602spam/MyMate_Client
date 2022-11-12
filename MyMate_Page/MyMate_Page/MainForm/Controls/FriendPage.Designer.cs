namespace MainForm.Controls
{
    partial class FriendPage
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
            this.rbtnFindFriend = new MainForm.Controls.RoundButton();
            this.panMyInfo = new System.Windows.Forms.Panel();
            this.panFriends = new System.Windows.Forms.Panel();
            this.panFriends.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnFindFriend
            // 
            this.rbtnFindFriend.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnFindFriend.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnFindFriend.BorderColor = System.Drawing.Color.Black;
            this.rbtnFindFriend.BorderRadius = 3;
            this.rbtnFindFriend.BorderSize = 0;
            this.rbtnFindFriend.FlatAppearance.BorderSize = 0;
            this.rbtnFindFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnFindFriend.ForeColor = System.Drawing.Color.White;
            this.rbtnFindFriend.Location = new System.Drawing.Point(829, 15);
            this.rbtnFindFriend.Name = "rbtnFindFriend";
            this.rbtnFindFriend.Size = new System.Drawing.Size(105, 40);
            this.rbtnFindFriend.TabIndex = 0;
            this.rbtnFindFriend.Text = "친구 추가";
            this.rbtnFindFriend.TextColor = System.Drawing.Color.White;
            this.rbtnFindFriend.UseVisualStyleBackColor = false;
            this.rbtnFindFriend.Click += new System.EventHandler(this.rbtnFindFriend_Click);
            // 
            // panMyInfo
            // 
            this.panMyInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMyInfo.Location = new System.Drawing.Point(0, 0);
            this.panMyInfo.Name = "panMyInfo";
            this.panMyInfo.Size = new System.Drawing.Size(950, 97);
            this.panMyInfo.TabIndex = 2;
            // 
            // panFriends
            // 
            this.panFriends.AutoScroll = true;
            this.panFriends.Controls.Add(this.rbtnFindFriend);
            this.panFriends.Dock = System.Windows.Forms.DockStyle.Top;
            this.panFriends.Location = new System.Drawing.Point(0, 97);
            this.panFriends.Name = "panFriends";
            this.panFriends.Size = new System.Drawing.Size(950, 535);
            this.panFriends.TabIndex = 3;
            // 
            // FriendPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panFriends);
            this.Controls.Add(this.panMyInfo);
            this.Name = "FriendPage";
            this.Size = new System.Drawing.Size(950, 632);
            this.panFriends.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton rbtnFindFriend;
        private Panel panMyInfo;
        private Panel panFriends;
    }
}
