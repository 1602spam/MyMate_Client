namespace MainForm
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rightPanel = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.PWPanel = new System.Windows.Forms.Panel();
            this.PWTxt = new System.Windows.Forms.TextBox();
            this.PWLabel = new System.Windows.Forms.Label();
            this.IDPanel = new System.Windows.Forms.Panel();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel.SuspendLayout();
            this.PWPanel.SuspendLayout();
            this.IDPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.Controls.Add(this.linkLabel2);
            this.rightPanel.Controls.Add(this.Label1);
            this.rightPanel.Controls.Add(this.linkLabel1);
            this.rightPanel.Controls.Add(this.checkBox1);
            this.rightPanel.Controls.Add(this.closeBtn);
            this.rightPanel.Controls.Add(this.loginBtn);
            this.rightPanel.Controls.Add(this.PWPanel);
            this.rightPanel.Controls.Add(this.PWLabel);
            this.rightPanel.Controls.Add(this.IDPanel);
            this.rightPanel.Controls.Add(this.IDLabel);
            this.rightPanel.Controls.Add(this.loginLabel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rightPanel.Location = new System.Drawing.Point(300, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(300, 400);
            this.rightPanel.TabIndex = 1;
            this.rightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightPanel_MouseDown);
            this.rightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rightPanel_MouseMove);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel2.Location = new System.Drawing.Point(207, 348);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(48, 13);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Sign up";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Location = new System.Drawing.Point(49, 348);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(152, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Don\'t have an account yet?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(187, 227);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot ID/PW";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(37, 227);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Keep me logged in";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(100)))));
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.Location = new System.Drawing.Point(275, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(100)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginBtn.Location = new System.Drawing.Point(37, 264);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(230, 40);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // PWPanel
            // 
            this.PWPanel.BackColor = System.Drawing.Color.White;
            this.PWPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PWPanel.Controls.Add(this.PWTxt);
            this.PWPanel.Location = new System.Drawing.Point(37, 176);
            this.PWPanel.Name = "PWPanel";
            this.PWPanel.Size = new System.Drawing.Size(230, 28);
            this.PWPanel.TabIndex = 4;
            // 
            // PWTxt
            // 
            this.PWTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PWTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWTxt.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PWTxt.Location = new System.Drawing.Point(5, 6);
            this.PWTxt.Margin = new System.Windows.Forms.Padding(5);
            this.PWTxt.MaxLength = 20;
            this.PWTxt.Name = "PWTxt";
            this.PWTxt.PasswordChar = '*';
            this.PWTxt.PlaceholderText = "Your Password";
            this.PWTxt.Size = new System.Drawing.Size(220, 16);
            this.PWTxt.TabIndex = 1;
            // 
            // PWLabel
            // 
            this.PWLabel.AutoSize = true;
            this.PWLabel.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PWLabel.Location = new System.Drawing.Point(39, 154);
            this.PWLabel.Name = "PWLabel";
            this.PWLabel.Size = new System.Drawing.Size(73, 19);
            this.PWLabel.TabIndex = 4;
            this.PWLabel.Text = "Password";
            // 
            // IDPanel
            // 
            this.IDPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDPanel.Controls.Add(this.IDTxt);
            this.IDPanel.Location = new System.Drawing.Point(37, 113);
            this.IDPanel.Name = "IDPanel";
            this.IDPanel.Size = new System.Drawing.Size(230, 28);
            this.IDPanel.TabIndex = 3;
            // 
            // IDTxt
            // 
            this.IDTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDTxt.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDTxt.Location = new System.Drawing.Point(5, 6);
            this.IDTxt.Margin = new System.Windows.Forms.Padding(5);
            this.IDTxt.MaxLength = 20;
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.PlaceholderText = "Your ID";
            this.IDTxt.Size = new System.Drawing.Size(218, 16);
            this.IDTxt.TabIndex = 0;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(40, 91);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(23, 19);
            this.IDLabel.TabIndex = 2;
            this.IDLabel.Text = "ID";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(37, 50);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(52, 21);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login";
            // 
            // logoLabel
            // 
            this.logoLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.logoLabel.Location = new System.Drawing.Point(24, 37);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(144, 39);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "MyMate";
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.leftPanel.Controls.Add(this.logoLabel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(300, 400);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.leftPanel_MouseDown);
            this.leftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.leftPanel_MouseMove);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.ControlBox = false;
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.PWPanel.ResumeLayout(false);
            this.PWPanel.PerformLayout();
            this.IDPanel.ResumeLayout(false);
            this.IDPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel rightPanel;
        private Panel IDPanel;
        private Label IDLabel;
        private Label loginLabel;
        private Button closeBtn;
        private Button loginBtn;
        private Panel PWPanel;
        private Label PWLabel;
        private LinkLabel linkLabel2;
        private Label Label1;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private TextBox PWTxt;
        private TextBox IDTxt;
        private Label logoLabel;
        private Panel leftPanel;
    }
}