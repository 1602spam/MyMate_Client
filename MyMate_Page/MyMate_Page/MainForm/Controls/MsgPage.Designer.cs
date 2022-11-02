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
            this.chatAddBtn = new System.Windows.Forms.Button();
            this.chatListPanel = new System.Windows.Forms.Panel();
            this.chatSendPanel = new System.Windows.Forms.TableLayoutPanel();
            this.plusBtn = new MainForm.Controls.RoundButton();
            this.sendBtn = new MainForm.Controls.RoundButton();
            this.chatTxt = new System.Windows.Forms.RichTextBox();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.chatListPanel.SuspendLayout();
            this.chatSendPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatAddBtn
            // 
            this.chatAddBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.chatAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chatAddBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chatAddBtn.FlatAppearance.BorderSize = 0;
            this.chatAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatAddBtn.ForeColor = System.Drawing.Color.Black;
            this.chatAddBtn.Location = new System.Drawing.Point(0, 0);
            this.chatAddBtn.Margin = new System.Windows.Forms.Padding(0);
            this.chatAddBtn.Name = "chatAddBtn";
            this.chatAddBtn.Size = new System.Drawing.Size(150, 40);
            this.chatAddBtn.TabIndex = 0;
            this.chatAddBtn.Text = "+";
            this.chatAddBtn.UseVisualStyleBackColor = false;
            // 
            // chatListPanel
            // 
            this.chatListPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chatListPanel.Controls.Add(this.chatAddBtn);
            this.chatListPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.chatListPanel.Location = new System.Drawing.Point(0, 0);
            this.chatListPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chatListPanel.Name = "chatListPanel";
            this.chatListPanel.Size = new System.Drawing.Size(150, 454);
            this.chatListPanel.TabIndex = 3;
            // 
            // chatSendPanel
            // 
            this.chatSendPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chatSendPanel.ColumnCount = 3;
            this.chatSendPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.chatSendPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chatSendPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.chatSendPanel.Controls.Add(this.plusBtn, 0, 0);
            this.chatSendPanel.Controls.Add(this.sendBtn, 2, 0);
            this.chatSendPanel.Controls.Add(this.chatTxt, 1, 0);
            this.chatSendPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chatSendPanel.Location = new System.Drawing.Point(150, 424);
            this.chatSendPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chatSendPanel.Name = "chatSendPanel";
            this.chatSendPanel.RowCount = 1;
            this.chatSendPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chatSendPanel.Size = new System.Drawing.Size(505, 30);
            this.chatSendPanel.TabIndex = 5;
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
            this.chatSendPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button chatAddBtn;
        private Panel chatListPanel;
        private TableLayoutPanel chatSendPanel;
        private RoundButton plusBtn;
        private RoundButton sendBtn;
        private RichTextBox chatTxt;
        private Panel chatPanel;
    }
}
