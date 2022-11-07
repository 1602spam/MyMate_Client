namespace MainForm.Controls
{
    partial class ServerChatList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerChatList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.addChatBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SListBtn = new System.Windows.Forms.Button();
            this.SCalendarBtn = new System.Windows.Forms.Button();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 473);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 344);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.SListBtn);
            this.panel2.Controls.Add(this.SCalendarBtn);
            this.panel2.Controls.Add(this.serverNameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 129);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 28);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.addChatBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(139, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(27, 28);
            this.panel6.TabIndex = 1;
            // 
            // addChatBtn
            // 
            this.addChatBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addChatBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addChatBtn.BackgroundImage")));
            this.addChatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addChatBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addChatBtn.FlatAppearance.BorderSize = 0;
            this.addChatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addChatBtn.Location = new System.Drawing.Point(0, 0);
            this.addChatBtn.Name = "addChatBtn";
            this.addChatBtn.Size = new System.Drawing.Size(27, 27);
            this.addChatBtn.TabIndex = 4;
            this.addChatBtn.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(139, 28);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "- Chattings";
            // 
            // SListBtn
            // 
            this.SListBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SListBtn.FlatAppearance.BorderSize = 0;
            this.SListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SListBtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SListBtn.Image = ((System.Drawing.Image)(resources.GetObject("SListBtn.Image")));
            this.SListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SListBtn.Location = new System.Drawing.Point(0, 61);
            this.SListBtn.Name = "SListBtn";
            this.SListBtn.Size = new System.Drawing.Size(166, 40);
            this.SListBtn.TabIndex = 2;
            this.SListBtn.Text = "       List      ";
            this.SListBtn.UseVisualStyleBackColor = true;
            this.SListBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // SCalendarBtn
            // 
            this.SCalendarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SCalendarBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SCalendarBtn.FlatAppearance.BorderSize = 0;
            this.SCalendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SCalendarBtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SCalendarBtn.Image = ((System.Drawing.Image)(resources.GetObject("SCalendarBtn.Image")));
            this.SCalendarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SCalendarBtn.Location = new System.Drawing.Point(0, 21);
            this.SCalendarBtn.Name = "SCalendarBtn";
            this.SCalendarBtn.Size = new System.Drawing.Size(166, 40);
            this.SCalendarBtn.TabIndex = 1;
            this.SCalendarBtn.Text = "Calendar      ";
            this.SCalendarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SCalendarBtn.UseVisualStyleBackColor = true;
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.serverNameLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.serverNameLabel.Location = new System.Drawing.Point(0, 0);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(80, 21);
            this.serverNameLabel.TabIndex = 0;
            this.serverNameLabel.Text = "- Server1";
            // 
            // ServerChatList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ServerChatList";
            this.Size = new System.Drawing.Size(166, 473);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label serverNameLabel;
        private Button SListBtn;
        private Button SCalendarBtn;
        private Panel panel4;
        private Panel panel6;
        private Button addChatBtn;
        private Panel panel5;
        private Label label1;
    }
}
