namespace MainForm.Controls
{
    partial class MsgPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgPage));
            this.chatListPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.addChatBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chatSendPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sendBtn = new MainForm.Controls.RoundButton();
            this.chatTxt = new System.Windows.Forms.RichTextBox();
            this.plusBtn = new MainForm.Controls.RoundButton();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.chatListPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.chatSendPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatListPanel
            // 
            this.chatListPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chatListPanel.Controls.Add(this.panel1);
            this.chatListPanel.Controls.Add(this.panel4);
            this.chatListPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.chatListPanel.Location = new System.Drawing.Point(0, 0);
            this.chatListPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chatListPanel.Name = "chatListPanel";
            this.chatListPanel.Size = new System.Drawing.Size(150, 454);
            this.chatListPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 426);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 28);
            this.panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.addChatBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(112, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(38, 28);
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
            this.addChatBtn.Size = new System.Drawing.Size(38, 27);
            this.addChatBtn.TabIndex = 4;
            this.addChatBtn.UseVisualStyleBackColor = true;
            this.addChatBtn.Click += new System.EventHandler(this.addChatBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(112, 28);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "- Chattings";
            // 
            // chatSendPanel
            // 
            this.chatSendPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chatSendPanel.ColumnCount = 3;
            this.chatSendPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.chatSendPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chatSendPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.chatSendPanel.Controls.Add(this.sendBtn, 2, 0);
            this.chatSendPanel.Controls.Add(this.chatTxt, 1, 0);
            this.chatSendPanel.Controls.Add(this.plusBtn, 0, 0);
            this.chatSendPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chatSendPanel.Location = new System.Drawing.Point(150, 424);
            this.chatSendPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chatSendPanel.Name = "chatSendPanel";
            this.chatSendPanel.RowCount = 1;
            this.chatSendPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chatSendPanel.Size = new System.Drawing.Size(505, 30);
            this.chatSendPanel.TabIndex = 5;
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.sendBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.sendBtn.BorderColor = System.Drawing.Color.Red;
            this.sendBtn.BorderRadius = 5;
            this.sendBtn.BorderSize = 0;
            this.sendBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(456, 1);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(1);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(48, 28);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "전송";
            this.sendBtn.TextColor = System.Drawing.Color.White;
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // chatTxt
            // 
            this.chatTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chatTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chatTxt.Location = new System.Drawing.Point(53, 3);
            this.chatTxt.Name = "chatTxt";
            this.chatTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.chatTxt.Size = new System.Drawing.Size(399, 24);
            this.chatTxt.TabIndex = 2;
            this.chatTxt.Text = "";
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.plusBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.plusBtn.BorderColor = System.Drawing.Color.Red;
            this.plusBtn.BorderRadius = 5;
            this.plusBtn.BorderSize = 0;
            this.plusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusBtn.FlatAppearance.BorderSize = 0;
            this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusBtn.ForeColor = System.Drawing.Color.White;
            this.plusBtn.Location = new System.Drawing.Point(1, 1);
            this.plusBtn.Margin = new System.Windows.Forms.Padding(1);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(48, 28);
            this.plusBtn.TabIndex = 0;
            this.plusBtn.Text = "+";
            this.plusBtn.TextColor = System.Drawing.Color.White;
            this.plusBtn.UseVisualStyleBackColor = false;
            // 
            // chatPanel
            // 
            this.chatPanel.AutoScroll = true;
            this.chatPanel.AutoSize = true;
            this.chatPanel.BackColor = System.Drawing.Color.White;
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatPanel.Location = new System.Drawing.Point(150, 0);
            this.chatPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(505, 424);
            this.chatPanel.TabIndex = 4;
            // 
            // MsgPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chatPanel);
            this.Controls.Add(this.chatSendPanel);
            this.Controls.Add(this.chatListPanel);
            this.Name = "MsgPage";
            this.Size = new System.Drawing.Size(655, 454);
            this.Load += new System.EventHandler(this.MsgPage_Load);
            this.chatListPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.chatSendPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel chatListPanel;
        private TableLayoutPanel chatSendPanel;
        private RoundButton plusBtn;
        private RoundButton sendBtn;
        private RichTextBox chatTxt;
        private Panel chatPanel;
        private Panel panel1;
        private Panel panel4;
        private Panel panel6;
        private Button addChatBtn;
        private Panel panel5;
        private Label label1;
    }
}
