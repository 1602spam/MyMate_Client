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
            this.lvSchedule = new System.Windows.Forms.ListView();
            this.ItemCode = new System.Windows.Forms.ColumnHeader("(없음)");
            this.ItemServerCode = new System.Windows.Forms.ColumnHeader();
            this.ItemScheduleCode = new System.Windows.Forms.ColumnHeader();
            this.ItemTitle = new System.Windows.Forms.ColumnHeader();
            this.ItemStartDate = new System.Windows.Forms.ColumnHeader();
            this.ItemEndDate = new System.Windows.Forms.ColumnHeader();
            this.ItemContext = new System.Windows.Forms.ColumnHeader();
            this.ItemCreator = new System.Windows.Forms.ColumnHeader();
            this.ItemIsPrivate = new System.Windows.Forms.ColumnHeader();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.lvItem = new System.Windows.Forms.ListView();
            this.Code = new System.Windows.Forms.ColumnHeader("(없음)");
            this.ServerCode = new System.Windows.Forms.ColumnHeader();
            this.OwnerCode = new System.Windows.Forms.ColumnHeader();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.tbCreator = new System.Windows.Forms.TextBox();
            this.cbIsPrivate = new System.Windows.Forms.ComboBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbScheduleCode = new System.Windows.Forms.TextBox();
            this.tbServerCode = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.btnAddScheduleItem = new System.Windows.Forms.Button();
            this.tbSTitle = new System.Windows.Forms.TextBox();
            this.tbSCreatorCode = new System.Windows.Forms.TextBox();
            this.tbSServerCode = new System.Windows.Forms.TextBox();
            this.tbSCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvSchedule
            // 
            this.lvSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemCode,
            this.ItemServerCode,
            this.ItemScheduleCode,
            this.ItemTitle,
            this.ItemStartDate,
            this.ItemEndDate,
            this.ItemContext,
            this.ItemCreator,
            this.ItemIsPrivate});
            this.lvSchedule.GridLines = true;
            this.lvSchedule.Location = new System.Drawing.Point(0, 0);
            this.lvSchedule.Name = "lvSchedule";
            this.lvSchedule.Size = new System.Drawing.Size(708, 167);
            this.lvSchedule.TabIndex = 1;
            this.lvSchedule.UseCompatibleStateImageBehavior = false;
            this.lvSchedule.View = System.Windows.Forms.View.Details;
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
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(4, 427);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(185, 23);
            this.btnAddSchedule.TabIndex = 5;
            this.btnAddSchedule.Text = "스케줄 일정 추가 및 수정";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // lvItem
            // 
            this.lvItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.ServerCode,
            this.OwnerCode,
            this.Title});
            this.lvItem.GridLines = true;
            this.lvItem.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvItem.Location = new System.Drawing.Point(3, 231);
            this.lvItem.Name = "lvItem";
            this.lvItem.Size = new System.Drawing.Size(705, 167);
            this.lvItem.TabIndex = 18;
            this.lvItem.UseCompatibleStateImageBehavior = false;
            this.lvItem.View = System.Windows.Forms.View.Details;
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
            // tbCreator
            // 
            this.tbCreator.Location = new System.Drawing.Point(501, 173);
            this.tbCreator.Name = "tbCreator";
            this.tbCreator.Size = new System.Drawing.Size(52, 23);
            this.tbCreator.TabIndex = 28;
            // 
            // cbIsPrivate
            // 
            this.cbIsPrivate.FormattingEnabled = true;
            this.cbIsPrivate.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbIsPrivate.Location = new System.Drawing.Point(572, 173);
            this.cbIsPrivate.Name = "cbIsPrivate";
            this.cbIsPrivate.Size = new System.Drawing.Size(51, 23);
            this.cbIsPrivate.TabIndex = 27;
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
            // btnAddScheduleItem
            // 
            this.btnAddScheduleItem.Location = new System.Drawing.Point(3, 202);
            this.btnAddScheduleItem.Name = "btnAddScheduleItem";
            this.btnAddScheduleItem.Size = new System.Drawing.Size(186, 23);
            this.btnAddScheduleItem.TabIndex = 29;
            this.btnAddScheduleItem.Text = "달력에 일정 추가 및 수정";
            this.btnAddScheduleItem.UseVisualStyleBackColor = true;
            this.btnAddScheduleItem.Click += new System.EventHandler(this.btnAddScheduleItem_Click);
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
            this.Controls.Add(this.tbSTitle);
            this.Controls.Add(this.tbSCreatorCode);
            this.Controls.Add(this.tbSServerCode);
            this.Controls.Add(this.tbSCode);
            this.Controls.Add(this.btnAddScheduleItem);
            this.Controls.Add(this.tbCreator);
            this.Controls.Add(this.cbIsPrivate);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbEndDate);
            this.Controls.Add(this.tbStartDate);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbScheduleCode);
            this.Controls.Add(this.tbServerCode);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lvItem);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.lvSchedule);
            this.Name = "CalendarPage";
            this.Size = new System.Drawing.Size(708, 453);
            this.Load += new System.EventHandler(this.CalendarPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvSchedule;
        private ColumnHeader ItemCode;
        private ColumnHeader ItemServerCode;
        private Button btnAddSchedule;
        private ColumnHeader ItemScheduleCode;
        private ColumnHeader ItemTitle;
        private ColumnHeader ItemStartDate;
        private ColumnHeader ItemContext;
        private ColumnHeader ItemCreator;
        private ColumnHeader ItemIsPrivate;
        private ListView lvItem;
        private ColumnHeader Code;
        private ColumnHeader ServerCode;
        private ColumnHeader OwnerCode;
        private ColumnHeader Title;
        private TextBox tbCreator;
        private ComboBox cbIsPrivate;
        private TextBox tbContent;
        private TextBox tbEndDate;
        private TextBox tbStartDate;
        private TextBox tbTitle;
        private TextBox tbScheduleCode;
        private TextBox tbServerCode;
        private TextBox tbCode;
        private Button btnAddScheduleItem;
        private TextBox tbSTitle;
        private TextBox tbSCreatorCode;
        private TextBox tbSServerCode;
        private TextBox tbSCode;
        private ColumnHeader ItemEndDate;
    }
}
