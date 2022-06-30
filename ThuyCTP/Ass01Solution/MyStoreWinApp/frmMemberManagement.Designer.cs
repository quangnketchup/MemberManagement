
namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            this.cboFillter = new System.Windows.Forms.ComboBox();
            this.cboFillterName = new System.Windows.Forms.ComboBox();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // cboFillter
            // 
            this.cboFillter.FormattingEnabled = true;
            this.cboFillter.Items.AddRange(new object[] {
            "United State",
            "Viet Nam"});
            this.cboFillter.Location = new System.Drawing.Point(444, 302);
            this.cboFillter.Name = "cboFillter";
            this.cboFillter.Size = new System.Drawing.Size(181, 28);
            this.cboFillter.TabIndex = 19;
            this.cboFillter.SelectionChangeCommitted += new System.EventHandler(this.cboFillter_SelectCity);
            // 
            // cboFillterName
            // 
            this.cboFillterName.FormattingEnabled = true;
            this.cboFillterName.Location = new System.Drawing.Point(668, 301);
            this.cboFillterName.Name = "cboFillterName";
            this.cboFillterName.Size = new System.Drawing.Size(181, 28);
            this.cboFillterName.TabIndex = 21;
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(123, 29);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(84, 20);
            this.lbMemberID.TabIndex = 0;
            this.lbMemberID.Text = "Member ID";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(123, 123);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(123, 78);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(109, 20);
            this.lbMemberName.TabIndex = 2;
            this.lbMemberName.Text = "Member Name";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(479, 81);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 3;
            this.lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(479, 127);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 4;
            this.lbCity.Text = "City";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(479, 29);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(566, 29);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 27);
            this.txtEmail.TabIndex = 7;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(236, 29);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(219, 27);
            this.txtMemberID.TabIndex = 8;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(234, 78);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(219, 27);
            this.txtMemberName.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(236, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(219, 27);
            this.txtPassword.TabIndex = 10;
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Items.AddRange(new object[] {
            "Ho Chi Minh",
            "Da Nang",
            "Ha Noi",
            "Phu Quoc",
            "Vung Tau"});
            this.cboCity.Location = new System.Drawing.Point(566, 123);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(250, 28);
            this.cboCity.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(670, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(419, 179);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(171, 179);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(386, 527);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(12, 335);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 29;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(950, 168);
            this.dgvMemberList.TabIndex = 16;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 302);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Seach member";
            this.txtSearch.Size = new System.Drawing.Size(202, 27);
            this.txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(234, 302);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Items.AddRange(new object[] {
            "Viet Nam",
            "America",
            "United State",
            "United Kingdom"});
            this.cboCountry.Location = new System.Drawing.Point(566, 81);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(250, 28);
            this.cboCountry.TabIndex = 20;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(869, 301);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(94, 29);
            this.btnFind.TabIndex = 22;
            this.btnFind.Text = "&Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "City";
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cboFillterName);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.cboFillter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbMemberID);
            this.Name = "frmMemberManagement";
            this.Text = "Member Management";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboFillter;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.ComboBox cboFillterName;
        private System.Windows.Forms.Button btnFind;
        private Label label1;
        private Label label2;
    }
}

