namespace WinformTest
{
    partial class Form1
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
            this.lvUsers = new System.Windows.Forms.ListView();
            this.chCode = new System.Windows.Forms.ColumnHeader();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chDesc = new System.Windows.Forms.ColumnHeader();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCode,
            this.chName,
            this.chDesc});
            this.lvUsers.GridLines = true;
            this.lvUsers.Location = new System.Drawing.Point(12, 12);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(522, 325);
            this.lvUsers.TabIndex = 0;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            // 
            // chCode
            // 
            this.chCode.Text = "코드";
            this.chCode.Width = 100;
            // 
            // chName
            // 
            this.chName.Text = "이름";
            // 
            // chDesc
            // 
            this.chDesc.Text = "설명";
            this.chDesc.Width = 250;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(423, 353);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 60);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(294, 390);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(123, 23);
            this.tbDesc.TabIndex = 2;
            this.tbDesc.TextChanged += new System.EventHandler(this.tbDesc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Edit Desc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code To Edit";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(294, 353);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(123, 23);
            this.tbCode.TabIndex = 5;
            this.tbCode.TextChanged += new System.EventHandler(this.tbCode_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lvUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvUsers;
        private ColumnHeader chCode;
        private ColumnHeader chName;
        private ColumnHeader chDesc;
        private Button btnEdit;
        private TextBox tbDesc;
        private Label label1;
        private Label label2;
        private TextBox tbCode;
    }
}