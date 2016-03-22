namespace LibraryManager
{
    partial class EditMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMemberForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAddBook = new System.Windows.Forms.Label();
            this.btnBrowsePhotoMember = new System.Windows.Forms.Button();
            this.pcBPhotoMember = new System.Windows.Forms.PictureBox();
            this.txtEmailMember = new System.Windows.Forms.TextBox();
            this.txtAddressMember = new System.Windows.Forms.TextBox();
            this.txtPhoneMember = new System.Windows.Forms.TextBox();
            this.txtDateMember = new System.Windows.Forms.TextBox();
            this.txtSurnameMember = new System.Windows.Forms.TextBox();
            this.txtNameMember = new System.Windows.Forms.TextBox();
            this.txtPassportMember = new System.Windows.Forms.TextBox();
            this.lblEmailMember = new System.Windows.Forms.Label();
            this.lblAddressMember = new System.Windows.Forms.Label();
            this.lblPhoneMember = new System.Windows.Forms.Label();
            this.lblDateReg = new System.Windows.Forms.Label();
            this.lblSurnameMember = new System.Windows.Forms.Label();
            this.lblNameMember = new System.Windows.Forms.Label();
            this.lblPassportMember = new System.Windows.Forms.Label();
            this.btnCancelMember = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBDeletedMember = new System.Windows.Forms.CheckBox();
            this.monthCalendarMember = new System.Windows.Forms.MonthCalendar();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBPhotoMember)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(172)))));
            this.pnlTop.Controls.Add(this.lblAddBook);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(484, 84);
            this.pnlTop.TabIndex = 14;
            // 
            // lblAddBook
            // 
            this.lblAddBook.AutoSize = true;
            this.lblAddBook.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBook.ForeColor = System.Drawing.Color.White;
            this.lblAddBook.Location = new System.Drawing.Point(118, 28);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(247, 37);
            this.lblAddBook.TabIndex = 0;
            this.lblAddBook.Text = "Edit Member Form";
            this.lblAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowsePhotoMember
            // 
            this.btnBrowsePhotoMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnBrowsePhotoMember.ForeColor = System.Drawing.Color.White;
            this.btnBrowsePhotoMember.Location = new System.Drawing.Point(336, 274);
            this.btnBrowsePhotoMember.Name = "btnBrowsePhotoMember";
            this.btnBrowsePhotoMember.Size = new System.Drawing.Size(115, 45);
            this.btnBrowsePhotoMember.TabIndex = 49;
            this.btnBrowsePhotoMember.Text = "Browse";
            this.btnBrowsePhotoMember.UseVisualStyleBackColor = false;
            this.btnBrowsePhotoMember.Click += new System.EventHandler(this.btnBrowsePhotoMember_Click);
            // 
            // pcBPhotoMember
            // 
            this.pcBPhotoMember.BackColor = System.Drawing.Color.White;
            this.pcBPhotoMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcBPhotoMember.Location = new System.Drawing.Point(336, 110);
            this.pcBPhotoMember.Name = "pcBPhotoMember";
            this.pcBPhotoMember.Size = new System.Drawing.Size(115, 150);
            this.pcBPhotoMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBPhotoMember.TabIndex = 48;
            this.pcBPhotoMember.TabStop = false;
            // 
            // txtEmailMember
            // 
            this.txtEmailMember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmailMember.Location = new System.Drawing.Point(125, 278);
            this.txtEmailMember.Name = "txtEmailMember";
            this.txtEmailMember.Size = new System.Drawing.Size(145, 29);
            this.txtEmailMember.TabIndex = 47;
            // 
            // txtAddressMember
            // 
            this.txtAddressMember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddressMember.Location = new System.Drawing.Point(125, 243);
            this.txtAddressMember.Name = "txtAddressMember";
            this.txtAddressMember.Size = new System.Drawing.Size(145, 29);
            this.txtAddressMember.TabIndex = 46;
            // 
            // txtPhoneMember
            // 
            this.txtPhoneMember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhoneMember.Location = new System.Drawing.Point(125, 208);
            this.txtPhoneMember.Name = "txtPhoneMember";
            this.txtPhoneMember.Size = new System.Drawing.Size(145, 29);
            this.txtPhoneMember.TabIndex = 45;
            // 
            // txtDateMember
            // 
            this.txtDateMember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDateMember.Location = new System.Drawing.Point(125, 348);
            this.txtDateMember.Name = "txtDateMember";
            this.txtDateMember.ReadOnly = true;
            this.txtDateMember.Size = new System.Drawing.Size(145, 29);
            this.txtDateMember.TabIndex = 44;
            // 
            // txtSurnameMember
            // 
            this.txtSurnameMember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSurnameMember.Location = new System.Drawing.Point(125, 172);
            this.txtSurnameMember.Name = "txtSurnameMember";
            this.txtSurnameMember.Size = new System.Drawing.Size(145, 29);
            this.txtSurnameMember.TabIndex = 43;
            // 
            // txtNameMember
            // 
            this.txtNameMember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameMember.Location = new System.Drawing.Point(125, 137);
            this.txtNameMember.Name = "txtNameMember";
            this.txtNameMember.Size = new System.Drawing.Size(145, 29);
            this.txtNameMember.TabIndex = 42;
            // 
            // txtPassportMember
            // 
            this.txtPassportMember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassportMember.Location = new System.Drawing.Point(125, 102);
            this.txtPassportMember.Name = "txtPassportMember";
            this.txtPassportMember.Size = new System.Drawing.Size(145, 29);
            this.txtPassportMember.TabIndex = 41;
            // 
            // lblEmailMember
            // 
            this.lblEmailMember.AutoSize = true;
            this.lblEmailMember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmailMember.Location = new System.Drawing.Point(32, 286);
            this.lblEmailMember.Name = "lblEmailMember";
            this.lblEmailMember.Size = new System.Drawing.Size(51, 21);
            this.lblEmailMember.TabIndex = 40;
            this.lblEmailMember.Text = "Email";
            // 
            // lblAddressMember
            // 
            this.lblAddressMember.AutoSize = true;
            this.lblAddressMember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddressMember.Location = new System.Drawing.Point(32, 251);
            this.lblAddressMember.Name = "lblAddressMember";
            this.lblAddressMember.Size = new System.Drawing.Size(73, 21);
            this.lblAddressMember.TabIndex = 39;
            this.lblAddressMember.Text = "Address";
            // 
            // lblPhoneMember
            // 
            this.lblPhoneMember.AutoSize = true;
            this.lblPhoneMember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneMember.Location = new System.Drawing.Point(32, 216);
            this.lblPhoneMember.Name = "lblPhoneMember";
            this.lblPhoneMember.Size = new System.Drawing.Size(57, 21);
            this.lblPhoneMember.TabIndex = 38;
            this.lblPhoneMember.Text = "Phone";
            // 
            // lblDateReg
            // 
            this.lblDateReg.AutoSize = true;
            this.lblDateReg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateReg.Location = new System.Drawing.Point(32, 356);
            this.lblDateReg.Name = "lblDateReg";
            this.lblDateReg.Size = new System.Drawing.Size(53, 21);
            this.lblDateReg.TabIndex = 37;
            this.lblDateReg.Text = "Date*";
            // 
            // lblSurnameMember
            // 
            this.lblSurnameMember.AutoSize = true;
            this.lblSurnameMember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurnameMember.Location = new System.Drawing.Point(32, 180);
            this.lblSurnameMember.Name = "lblSurnameMember";
            this.lblSurnameMember.Size = new System.Drawing.Size(84, 21);
            this.lblSurnameMember.TabIndex = 36;
            this.lblSurnameMember.Text = "Surname*";
            // 
            // lblNameMember
            // 
            this.lblNameMember.AutoSize = true;
            this.lblNameMember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameMember.Location = new System.Drawing.Point(32, 145);
            this.lblNameMember.Name = "lblNameMember";
            this.lblNameMember.Size = new System.Drawing.Size(62, 21);
            this.lblNameMember.TabIndex = 35;
            this.lblNameMember.Text = "Name*";
            // 
            // lblPassportMember
            // 
            this.lblPassportMember.AutoSize = true;
            this.lblPassportMember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassportMember.Location = new System.Drawing.Point(32, 110);
            this.lblPassportMember.Name = "lblPassportMember";
            this.lblPassportMember.Size = new System.Drawing.Size(85, 21);
            this.lblPassportMember.TabIndex = 34;
            this.lblPassportMember.Text = "Passport*";
            // 
            // btnCancelMember
            // 
            this.btnCancelMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnCancelMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnCancelMember.FlatAppearance.BorderSize = 2;
            this.btnCancelMember.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnCancelMember.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelMember.ForeColor = System.Drawing.Color.White;
            this.btnCancelMember.Location = new System.Drawing.Point(351, 509);
            this.btnCancelMember.Name = "btnCancelMember";
            this.btnCancelMember.Size = new System.Drawing.Size(100, 40);
            this.btnCancelMember.TabIndex = 33;
            this.btnCancelMember.Text = "Cancel";
            this.btnCancelMember.UseVisualStyleBackColor = false;
            this.btnCancelMember.Click += new System.EventHandler(this.btnCancelMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnEditMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnEditMember.FlatAppearance.BorderSize = 2;
            this.btnEditMember.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnEditMember.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditMember.ForeColor = System.Drawing.Color.White;
            this.btnEditMember.Location = new System.Drawing.Point(351, 463);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(100, 40);
            this.btnEditMember.TabIndex = 32;
            this.btnEditMember.Text = "Edit";
            this.btnEditMember.UseVisualStyleBackColor = false;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Deleted";
            // 
            // chkBDeletedMember
            // 
            this.chkBDeletedMember.AutoSize = true;
            this.chkBDeletedMember.Location = new System.Drawing.Point(125, 325);
            this.chkBDeletedMember.Name = "chkBDeletedMember";
            this.chkBDeletedMember.Size = new System.Drawing.Size(91, 17);
            this.chkBDeletedMember.TabIndex = 53;
            this.chkBDeletedMember.Text = "Check for yes";
            this.chkBDeletedMember.UseVisualStyleBackColor = true;
            // 
            // monthCalendarMember
            // 
            this.monthCalendarMember.Location = new System.Drawing.Point(43, 388);
            this.monthCalendarMember.Name = "monthCalendarMember";
            this.monthCalendarMember.TabIndex = 54;
            this.monthCalendarMember.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarMember_DateSelected);
            // 
            // EditMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.monthCalendarMember);
            this.Controls.Add(this.chkBDeletedMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowsePhotoMember);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pcBPhotoMember);
            this.Controls.Add(this.txtEmailMember);
            this.Controls.Add(this.btnEditMember);
            this.Controls.Add(this.txtAddressMember);
            this.Controls.Add(this.btnCancelMember);
            this.Controls.Add(this.txtPhoneMember);
            this.Controls.Add(this.lblPassportMember);
            this.Controls.Add(this.txtDateMember);
            this.Controls.Add(this.lblNameMember);
            this.Controls.Add(this.txtSurnameMember);
            this.Controls.Add(this.lblSurnameMember);
            this.Controls.Add(this.txtNameMember);
            this.Controls.Add(this.lblDateReg);
            this.Controls.Add(this.txtPassportMember);
            this.Controls.Add(this.lblPhoneMember);
            this.Controls.Add(this.lblEmailMember);
            this.Controls.Add(this.lblAddressMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMemberForm";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBPhotoMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAddBook;
        private System.Windows.Forms.Button btnBrowsePhotoMember;
        private System.Windows.Forms.PictureBox pcBPhotoMember;
        private System.Windows.Forms.TextBox txtEmailMember;
        private System.Windows.Forms.TextBox txtAddressMember;
        private System.Windows.Forms.TextBox txtPhoneMember;
        private System.Windows.Forms.TextBox txtDateMember;
        private System.Windows.Forms.TextBox txtSurnameMember;
        private System.Windows.Forms.TextBox txtNameMember;
        private System.Windows.Forms.TextBox txtPassportMember;
        private System.Windows.Forms.Label lblEmailMember;
        private System.Windows.Forms.Label lblAddressMember;
        private System.Windows.Forms.Label lblPhoneMember;
        private System.Windows.Forms.Label lblDateReg;
        private System.Windows.Forms.Label lblSurnameMember;
        private System.Windows.Forms.Label lblNameMember;
        private System.Windows.Forms.Label lblPassportMember;
        private System.Windows.Forms.Button btnCancelMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBDeletedMember;
        private System.Windows.Forms.MonthCalendar monthCalendarMember;
    }
}