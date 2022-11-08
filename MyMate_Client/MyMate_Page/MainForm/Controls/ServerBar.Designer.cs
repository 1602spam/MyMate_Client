namespace MainForm.Controls
{
    partial class ServerBar
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.roundButton1 = new MainForm.Controls.RoundButton();
            this.roundButton2 = new MainForm.Controls.RoundButton();
            this.roundButton3 = new MainForm.Controls.RoundButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 500);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.roundButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 50);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.roundButton2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 50);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.roundButton3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 400);
            this.panel4.TabIndex = 2;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton1.BorderColor = System.Drawing.Color.Red;
            this.roundButton1.BorderRadius = 20;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(5, 5);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(40, 40);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton2.BorderColor = System.Drawing.Color.Red;
            this.roundButton2.BorderRadius = 20;
            this.roundButton2.BorderSize = 0;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(5, 5);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(40, 40);
            this.roundButton2.TabIndex = 1;
            this.roundButton2.Text = "roundButton2";
            this.roundButton2.TextColor = System.Drawing.Color.White;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton3.BorderColor = System.Drawing.Color.Red;
            this.roundButton3.BorderRadius = 20;
            this.roundButton3.BorderSize = 0;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.ForeColor = System.Drawing.Color.White;
            this.roundButton3.Location = new System.Drawing.Point(5, 5);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(40, 40);
            this.roundButton3.TabIndex = 2;
            this.roundButton3.Text = "roundButton3";
            this.roundButton3.TextColor = System.Drawing.Color.White;
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // ServerBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ServerBar";
            this.Size = new System.Drawing.Size(50, 500);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private RoundButton roundButton3;
        private Panel panel3;
        private RoundButton roundButton2;
        private Panel panel2;
        private RoundButton roundButton1;
    }
}
