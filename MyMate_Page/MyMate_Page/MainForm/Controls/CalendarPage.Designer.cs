namespace MainForm.Controls
{
    partial class CalendarPage
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "fgkj",
            "sfa",
            "sf",
            "s",
            "s",
            "s"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.ItemCode = new System.Windows.Forms.ColumnHeader("(없음)");
            this.ItemServerCode = new System.Windows.Forms.ColumnHeader();
            this.ItemScheduleCode = new System.Windows.Forms.ColumnHeader();
            this.ItemTitle = new System.Windows.Forms.ColumnHeader();
            this.ItemStartDate = new System.Windows.Forms.ColumnHeader();
            this.ItemEndDate = new System.Windows.Forms.ColumnHeader();
            this.ItemContext = new System.Windows.Forms.ColumnHeader();
            this.ItemCreator = new System.Windows.Forms.ColumnHeader();
            this.ItemIsPrivate = new System.Windows.Forms.ColumnHeader();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Code = new System.Windows.Forms.ColumnHeader("(없음)");
            this.ServerCode = new System.Windows.Forms.ColumnHeader();
            this.OwnerCode = new System.Windows.Forms.ColumnHeader();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.Users = new System.Windows.Forms.ColumnHeader();
            this.tbCreator = new System.Windows.Forms.TextBox();
            this.cbIsPublic = new System.Windows.Forms.ComboBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbScheduleCode = new System.Windows.Forms.TextBox();
            this.tbServerCode = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tbSTitle = new System.Windows.Forms.TextBox();
            this.tbSCreatorCode = new System.Windows.Forms.TextBox();
            this.tbSServerCode = new System.Windows.Forms.TextBox();
            this.tbSCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemCode,
            this.ItemServerCode,
            this.ItemScheduleCode,
            this.ItemTitle,
            this.ItemStartDate,
            this.ItemEndDate,
            this.ItemContext,
            this.ItemCreator,
            this.ItemIsPrivate});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(708, 167);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ItemCode
            // 
            this.ItemCode.Text = "항목코드";
            // 
            // ItemServerCode
            // 
            this.ItemServerCode.Text = "서버코드";
            this.ItemServerCode.Width = 80;
            // 
            // ItemScheduleCode
            // 
            this.ItemScheduleCode.Text = "스케줄코드";
            this.ItemScheduleCode.Width = 100;
            // 
            // ItemTitle
            // 
            this.ItemTitle.Text = "제목";
            // 
            // ItemStartDate
            // 
            this.ItemStartDate.Text = "시작날짜";
            this.ItemStartDate.Width = 100;
            // 
            // ItemEndDate
            // 
            this.ItemEndDate.Text = "종료날짜";
            this.ItemEndDate.Width = 100;
            // 
            // ItemContext
            // 
            this.ItemContext.Text = "내용";
            // 
            // ItemCreator
            // 
            this.ItemCreator.Text = "생성자";
            // 
            // ItemIsPrivate
            // 
            this.ItemIsPrivate.Text = "공개여부";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "스케줄 일정 추가";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(129, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "스케줄 일정 수정";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.ServerCode,
            this.OwnerCode,
            this.Title,
            this.Users});
            this.listView2.GridLines = true;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView2.Location = new System.Drawing.Point(3, 231);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(705, 167);
            this.listView2.TabIndex = 18;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // Code
            // 
            this.Code.Text = "캘린더코드";
            // 
            // ServerCode
            // 
            this.ServerCode.Text = "서버코드";
            this.ServerCode.Width = 80;
            // 
            // OwnerCode
            // 
            this.OwnerCode.Text = "생성자코드";
            this.OwnerCode.Width = 100;
            // 
            // Title
            // 
            this.Title.Text = "제목";
            this.Title.Width = 200;
            // 
            // Users
            // 
            this.Users.Text = "유저목록";
            this.Users.Width = 130;
            // 
            // tbCreator
            // 
            this.tbCreator.Location = new System.Drawing.Point(501, 173);
            this.tbCreator.Name = "tbCreator";
            this.tbCreator.Size = new System.Drawing.Size(52, 23);
            this.tbCreator.TabIndex = 28;
            // 
            // cbIsPublic
            // 
            this.cbIsPublic.FormattingEnabled = true;
            this.cbIsPublic.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbIsPublic.Location = new System.Drawing.Point(572, 173);
            this.cbIsPublic.Name = "cbIsPublic";
            this.cbIsPublic.Size = new System.Drawing.Size(51, 23);
            this.cbIsPublic.TabIndex = 27;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(450, 173);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(45, 23);
            this.tbContent.TabIndex = 25;
            // 
            // tbEndDate
            // 
            this.tbEndDate.Location = new System.Drawing.Point(344, 173);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(100, 23);
            this.tbEndDate.TabIndex = 24;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(238, 173);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(100, 23);
            this.tbStartDate.TabIndex = 23;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(190, 173);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(42, 23);
            this.tbTitle.TabIndex = 22;
            // 
            // tbScheduleCode
            // 
            this.tbScheduleCode.Location = new System.Drawing.Point(126, 173);
            this.tbScheduleCode.Name = "tbScheduleCode";
            this.tbScheduleCode.Size = new System.Drawing.Size(41, 23);
            this.tbScheduleCode.TabIndex = 21;
            // 
            // tbServerCode
            // 
            this.tbServerCode.Location = new System.Drawing.Point(63, 173);
            this.tbServerCode.Name = "tbServerCode";
            this.tbServerCode.Size = new System.Drawing.Size(39, 23);
            this.tbServerCode.TabIndex = 20;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(3, 173);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(42, 23);
            this.tbCode.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "달력에 일정 수정";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "달력에 일정 추가";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(450, 404);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(45, 23);
            this.textBox10.TabIndex = 37;
            // 
            // tbSTitle
            // 
            this.tbSTitle.Location = new System.Drawing.Point(238, 404);
            this.tbSTitle.Name = "tbSTitle";
            this.tbSTitle.Size = new System.Drawing.Size(100, 23);
            this.tbSTitle.TabIndex = 36;
            // 
            // tbSCreatorCode
            // 
            this.tbSCreatorCode.Location = new System.Drawing.Point(126, 404);
            this.tbSCreatorCode.Name = "tbSCreatorCode";
            this.tbSCreatorCode.Size = new System.Drawing.Size(41, 23);
            this.tbSCreatorCode.TabIndex = 33;
            // 
            // tbSServerCode
            // 
            this.tbSServerCode.Location = new System.Drawing.Point(63, 404);
            this.tbSServerCode.Name = "tbSServerCode";
            this.tbSServerCode.Size = new System.Drawing.Size(39, 23);
            this.tbSServerCode.TabIndex = 32;
            // 
            // tbSCode
            // 
            this.tbSCode.Location = new System.Drawing.Point(3, 404);
            this.tbSCode.Name = "tbSCode";
            this.tbSCode.Size = new System.Drawing.Size(42, 23);
            this.tbSCode.TabIndex = 31;
            // 
            // CalendarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.tbSTitle);
            this.Controls.Add(this.tbSCreatorCode);
            this.Controls.Add(this.tbSServerCode);
            this.Controls.Add(this.tbSCode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCreator);
            this.Controls.Add(this.cbIsPublic);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbEndDate);
            this.Controls.Add(this.tbStartDate);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbScheduleCode);
            this.Controls.Add(this.tbServerCode);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Name = "CalendarPage";
            this.Size = new System.Drawing.Size(708, 453);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader ItemCode;
        private ColumnHeader ItemServerCode;
        private Button button3;
        private Button button4;
        private ColumnHeader ItemScheduleCode;
        private ColumnHeader ItemTitle;
        private ColumnHeader ItemStartDate;
        private ColumnHeader ItemContext;
        private ColumnHeader ItemCreator;
        private ColumnHeader ItemIsPrivate;
        private ListView listView2;
        private ColumnHeader Code;
        private ColumnHeader ServerCode;
        private ColumnHeader OwnerCode;
        private ColumnHeader Title;
        private ColumnHeader Users;
        private TextBox tbCreator;
        private ComboBox cbIsPublic;
        private TextBox tbContent;
        private TextBox tbEndDate;
        private TextBox tbStartDate;
        private TextBox tbTitle;
        private TextBox tbScheduleCode;
        private TextBox tbServerCode;
        private TextBox tbCode;
        private Button button2;
        private Button button1;
        private TextBox textBox10;
        private TextBox tbSTitle;
        private TextBox tbSCreatorCode;
        private TextBox tbSServerCode;
        private TextBox tbSCode;
        private ColumnHeader ItemEndDate;
    }
}
