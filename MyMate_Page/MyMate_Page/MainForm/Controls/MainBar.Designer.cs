namespace MainForm.Controls
{
    partial class MainBar
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
            this.TableBarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FriendPanel = new System.Windows.Forms.Panel();
            this.FriendBtn = new System.Windows.Forms.Button();
            this.MsgPanel = new System.Windows.Forms.Panel();
            this.CalendarBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MsgBtn = new System.Windows.Forms.Button();
            this.ListBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TableBarPanel.SuspendLayout();
            this.FriendPanel.SuspendLayout();
            this.MsgPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableBarPanel
            // 
            this.TableBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.TableBarPanel.ColumnCount = 6;
            this.TableBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableBarPanel.Controls.Add(this.FriendPanel, 4, 0);
            this.TableBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TableBarPanel.Name = "TableBarPanel";
            this.TableBarPanel.RowCount = 1;
            this.TableBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableBarPanel.Size = new System.Drawing.Size(200, 100);
            this.TableBarPanel.TabIndex = 0;
            // 
            // FriendPanel
            // 
            this.FriendPanel.BackColor = System.Drawing.Color.White;
            this.FriendPanel.Controls.Add(this.FriendBtn);
            this.FriendPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FriendPanel.Location = new System.Drawing.Point(150, 0);
            this.FriendPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FriendPanel.Name = "FriendPanel";
            this.FriendPanel.Size = new System.Drawing.Size(50, 100);
            this.FriendPanel.TabIndex = 1;
            // 
            // FriendBtn
            // 
            this.FriendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.FriendBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.FriendBtn.FlatAppearance.BorderSize = 0;
            this.FriendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FriendBtn.Location = new System.Drawing.Point(0, 0);
            this.FriendBtn.Margin = new System.Windows.Forms.Padding(0);
            this.FriendBtn.Name = "FriendBtn";
            this.FriendBtn.Size = new System.Drawing.Size(50, 47);
            this.FriendBtn.TabIndex = 0;
            this.FriendBtn.Text = "Friend";
            this.FriendBtn.UseVisualStyleBackColor = false;
            // 
            // MsgPanel
            // 
            this.MsgPanel.BackColor = System.Drawing.Color.White;
            this.MsgPanel.Controls.Add(this.CalendarBtn);
            this.MsgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MsgPanel.Location = new System.Drawing.Point(50, 0);
            this.MsgPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MsgPanel.Name = "MsgPanel";
            this.MsgPanel.Size = new System.Drawing.Size(50, 100);
            this.MsgPanel.TabIndex = 0;
            // 
            // CalendarBtn
            // 
            this.CalendarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CalendarBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalendarBtn.FlatAppearance.BorderSize = 0;
            this.CalendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalendarBtn.Location = new System.Drawing.Point(0, 0);
            this.CalendarBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CalendarBtn.Name = "CalendarBtn";
            this.CalendarBtn.Size = new System.Drawing.Size(50, 47);
            this.CalendarBtn.TabIndex = 0;
            this.CalendarBtn.Text = "Calendar";
            this.CalendarBtn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.MsgBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ListBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // MsgBtn
            // 
            this.MsgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.MsgBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MsgBtn.FlatAppearance.BorderSize = 0;
            this.MsgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsgBtn.Location = new System.Drawing.Point(150, 0);
            this.MsgBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MsgBtn.Name = "MsgBtn";
            this.MsgBtn.Size = new System.Drawing.Size(50, 50);
            this.MsgBtn.TabIndex = 0;
            this.MsgBtn.Text = "Msg";
            this.MsgBtn.UseVisualStyleBackColor = false;
            this.MsgBtn.Click += new System.EventHandler(this.MsgBtn_Click);
            // 
            // ListBtn
            // 
            this.ListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ListBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBtn.FlatAppearance.BorderSize = 0;
            this.ListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListBtn.Location = new System.Drawing.Point(250, 0);
            this.ListBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ListBtn.Name = "ListBtn";
            this.ListBtn.Size = new System.Drawing.Size(50, 50);
            this.ListBtn.TabIndex = 0;
            this.ListBtn.Text = "List";
            this.ListBtn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(200, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "Calendar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(300, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Friend";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MainBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainBar";
            this.Size = new System.Drawing.Size(500, 50);
            this.TableBarPanel.ResumeLayout(false);
            this.FriendPanel.ResumeLayout(false);
            this.MsgPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TableBarPanel;
        private Panel FriendPanel;
        private Button FriendBtn;
        private Panel MsgPanel;
        private Button CalendarBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Button MsgBtn;
        private Button ListBtn;
        private Button button2;
        private Button button1;
    }
}
