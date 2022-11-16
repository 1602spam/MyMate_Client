namespace MainForm.Controls
{
    partial class CalendarPage1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OKBtn = new System.Windows.Forms.Button();
            this.removeSDBtn = new System.Windows.Forms.Button();
            this.addSDBtn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.roundButton1 = new MainForm.Controls.RoundButton();
            this.roundButton2 = new MainForm.Controls.RoundButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DayTxt = new System.Windows.Forms.TextBox();
            this.MonTxt = new System.Windows.Forms.TextBox();
            this.yearTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.c = new Calender.Calender();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 482);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 150);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OKBtn);
            this.panel2.Controls.Add(this.removeSDBtn);
            this.panel2.Controls.Add(this.addSDBtn);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.DayTxt);
            this.panel2.Controls.Add(this.MonTxt);
            this.panel2.Controls.Add(this.yearTxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(770, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 632);
            this.panel2.TabIndex = 2;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(150, 15);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(24, 42);
            this.OKBtn.TabIndex = 9;
            this.OKBtn.Text = "확인";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // removeSDBtn
            // 
            this.removeSDBtn.Location = new System.Drawing.Point(90, 62);
            this.removeSDBtn.Name = "removeSDBtn";
            this.removeSDBtn.Size = new System.Drawing.Size(75, 23);
            this.removeSDBtn.TabIndex = 8;
            this.removeSDBtn.Text = "일정삭제";
            this.removeSDBtn.UseVisualStyleBackColor = true;
            // 
            // addSDBtn
            // 
            this.addSDBtn.Location = new System.Drawing.Point(9, 62);
            this.addSDBtn.Name = "addSDBtn";
            this.addSDBtn.Size = new System.Drawing.Size(75, 23);
            this.addSDBtn.TabIndex = 7;
            this.addSDBtn.Text = "일정 추가";
            this.addSDBtn.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.Controls.Add(this.roundButton1);
            this.panel8.Controls.Add(this.roundButton2);
            this.panel8.Location = new System.Drawing.Point(0, 91);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(180, 538);
            this.panel8.TabIndex = 6;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton1.BorderColor = System.Drawing.Color.Red;
            this.roundButton1.BorderRadius = 15;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(9, 18);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(30, 30);
            this.roundButton1.TabIndex = 1;
            this.roundButton1.Text = "◀";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.LBtn_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton2.BorderColor = System.Drawing.Color.Red;
            this.roundButton2.BorderRadius = 15;
            this.roundButton2.BorderSize = 0;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(45, 18);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(30, 30);
            this.roundButton2.TabIndex = 3;
            this.roundButton2.Text = "▶";
            this.roundButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundButton2.TextColor = System.Drawing.Color.White;
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.RBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Year";
            // 
            // DayTxt
            // 
            this.DayTxt.Location = new System.Drawing.Point(116, 33);
            this.DayTxt.Name = "DayTxt";
            this.DayTxt.Size = new System.Drawing.Size(30, 23);
            this.DayTxt.TabIndex = 2;
            // 
            // MonTxt
            // 
            this.MonTxt.Location = new System.Drawing.Point(70, 33);
            this.MonTxt.Name = "MonTxt";
            this.MonTxt.Size = new System.Drawing.Size(40, 23);
            this.MonTxt.TabIndex = 1;
            // 
            // yearTxt
            // 
            this.yearTxt.Location = new System.Drawing.Point(9, 33);
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(57, 23);
            this.yearTxt.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.Panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 482);
            this.panel3.TabIndex = 3;
            // 
            // Panel7
            // 
            this.Panel7.AutoScroll = true;
            this.Panel7.Controls.Add(this.c);
            this.Panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel7.Location = new System.Drawing.Point(30, 0);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(710, 482);
            this.Panel7.TabIndex = 3;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Dock = System.Windows.Forms.DockStyle.Top;
            this.c.Location = new System.Drawing.Point(0, 0);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(710, 53);
            this.c.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(740, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(30, 482);
            this.panel6.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 482);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Location = new System.Drawing.Point(30, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(740, 482);
            this.panel5.TabIndex = 2;
            // 
            // CalendarPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CalendarPage1";
            this.Size = new System.Drawing.Size(950, 632);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button OKBtn;
        private Button removeSDBtn;
        private Button addSDBtn;
        private Panel panel8;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox DayTxt;
        private TextBox MonTxt;
        private TextBox yearTxt;
        private Panel panel3;
        private Panel Panel7;
        private Calender.Calender c;
        private Panel panel6;
        private Panel panel4;
        private Panel panel5;
        private RoundButton roundButton1;
        private RoundButton roundButton2;
    }
}
