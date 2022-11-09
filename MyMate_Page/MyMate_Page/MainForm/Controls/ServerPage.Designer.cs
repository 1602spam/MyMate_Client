namespace MainForm.Controls
{
    partial class ServerPage
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
            this.SChatListPanel = new System.Windows.Forms.Panel();
            this.SFriendsPanel = new System.Windows.Forms.Panel();
            this.SChatPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SChatListPanel
            // 
            this.SChatListPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SChatListPanel.Location = new System.Drawing.Point(0, 0);
            this.SChatListPanel.Name = "SChatListPanel";
            this.SChatListPanel.Size = new System.Drawing.Size(150, 427);
            this.SChatListPanel.TabIndex = 0;
            // 
            // SFriendsPanel
            // 
            this.SFriendsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SFriendsPanel.Location = new System.Drawing.Point(520, 0);
            this.SFriendsPanel.Name = "SFriendsPanel";
            this.SFriendsPanel.Size = new System.Drawing.Size(150, 427);
            this.SFriendsPanel.TabIndex = 1;
            // 
            // SChatPanel
            // 
            this.SChatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SChatPanel.Location = new System.Drawing.Point(150, 0);
            this.SChatPanel.Name = "SChatPanel";
            this.SChatPanel.Size = new System.Drawing.Size(370, 427);
            this.SChatPanel.TabIndex = 2;
            // 
            // ServerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SChatPanel);
            this.Controls.Add(this.SFriendsPanel);
            this.Controls.Add(this.SChatListPanel);
            this.Name = "ServerPage";
            this.Size = new System.Drawing.Size(670, 427);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SChatListPanel;
        private Panel SFriendsPanel;
        private Panel SChatPanel;
    }
}
