namespace MainForm.Controls
{
    partial class ServerChat
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chatSendPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sendBtn = new MainForm.Controls.RoundButton();
            this.chatTxt = new System.Windows.Forms.RichTextBox();
            this.plusBtn = new MainForm.Controls.RoundButton();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.chatSendPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chatPanel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 481);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chatSendPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 451);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 30);
            this.panel3.TabIndex = 0;
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
            this.chatSendPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatSendPanel.Location = new System.Drawing.Point(0, 0);
            this.chatSendPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chatSendPanel.Name = "chatSendPanel";
            this.chatSendPanel.RowCount = 1;
            this.chatSendPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chatSendPanel.Size = new System.Drawing.Size(678, 30);
            this.chatSendPanel.TabIndex = 6;
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
            this.sendBtn.Location = new System.Drawing.Point(629, 1);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(1);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(48, 28);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "전송";
            this.sendBtn.TextColor = System.Drawing.Color.White;
            this.sendBtn.UseVisualStyleBackColor = false;
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
            this.chatTxt.Size = new System.Drawing.Size(572, 24);
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
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatPanel.Location = new System.Drawing.Point(0, 0);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(678, 451);
            this.chatPanel.TabIndex = 1;
            // 
            // ServerChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ServerChat";
            this.Size = new System.Drawing.Size(678, 481);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.chatSendPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Panel chatPanel;
        private TableLayoutPanel chatSendPanel;
        private RoundButton sendBtn;
        private RichTextBox chatTxt;
        private RoundButton plusBtn;
    }
}
