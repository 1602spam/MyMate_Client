namespace MainForm.PopupControls
{
    partial class SearchFriendPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.rbtnSearch = new MainForm.Controls.RoundButton();
            this.rbtnAdd = new MainForm.Controls.RoundButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.rbtnProfile = new MainForm.Controls.RoundButton();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(82, 114);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(159, 23);
            this.tbID.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(82, 96);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 15);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // rbtnSearch
            // 
            this.rbtnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnSearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnSearch.BorderColor = System.Drawing.Color.Red;
            this.rbtnSearch.BorderRadius = 3;
            this.rbtnSearch.BorderSize = 0;
            this.rbtnSearch.FlatAppearance.BorderSize = 0;
            this.rbtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnSearch.ForeColor = System.Drawing.Color.White;
            this.rbtnSearch.Location = new System.Drawing.Point(110, 162);
            this.rbtnSearch.Name = "rbtnSearch";
            this.rbtnSearch.Size = new System.Drawing.Size(108, 40);
            this.rbtnSearch.TabIndex = 2;
            this.rbtnSearch.Text = "검색";
            this.rbtnSearch.TextColor = System.Drawing.Color.White;
            this.rbtnSearch.UseVisualStyleBackColor = false;
            this.rbtnSearch.Click += new System.EventHandler(this.rbtnSearch_Click);
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnAdd.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnAdd.BorderColor = System.Drawing.Color.Red;
            this.rbtnAdd.BorderRadius = 3;
            this.rbtnAdd.BorderSize = 0;
            this.rbtnAdd.FlatAppearance.BorderSize = 0;
            this.rbtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnAdd.ForeColor = System.Drawing.Color.White;
            this.rbtnAdd.Location = new System.Drawing.Point(221, 299);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(78, 40);
            this.rbtnAdd.TabIndex = 3;
            this.rbtnAdd.Text = "추가";
            this.rbtnAdd.TextColor = System.Drawing.Color.White;
            this.rbtnAdd.UseVisualStyleBackColor = false;
            this.rbtnAdd.Click += new System.EventHandler(this.rbtnAdd_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(86, 312);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 15);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username123";
            // 
            // rbtnProfile
            // 
            this.rbtnProfile.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnProfile.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnProfile.BorderColor = System.Drawing.Color.Red;
            this.rbtnProfile.BorderRadius = 25;
            this.rbtnProfile.BorderSize = 0;
            this.rbtnProfile.FlatAppearance.BorderSize = 0;
            this.rbtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnProfile.ForeColor = System.Drawing.Color.White;
            this.rbtnProfile.Location = new System.Drawing.Point(30, 294);
            this.rbtnProfile.Name = "rbtnProfile";
            this.rbtnProfile.Size = new System.Drawing.Size(50, 50);
            this.rbtnProfile.TabIndex = 5;
            this.rbtnProfile.TextColor = System.Drawing.Color.White;
            this.rbtnProfile.UseVisualStyleBackColor = false;
            // 
            // SearchFriendPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 450);
            this.Controls.Add(this.rbtnProfile);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.rbtnAdd);
            this.Controls.Add(this.rbtnSearch);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbID);
            this.Name = "SearchFriendPopup";
            this.Text = "SearchFriend";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchFriendPopup_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchFriendPopup_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbID;
        private Label lblID;
        private Controls.RoundButton rbtnSearch;
        private Controls.RoundButton rbtnAdd;
        private Label lblUsername;
        private Controls.RoundButton rbtnProfile;
    }
}