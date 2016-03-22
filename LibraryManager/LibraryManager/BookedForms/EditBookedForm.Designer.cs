namespace LibraryManager
{
    partial class EditBookedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBookedForm));
            this.btnBrowseMembersBooked = new System.Windows.Forms.Button();
            this.btnBrowseBooksBooked = new System.Windows.Forms.Button();
            this.txtDueDateBooked = new System.Windows.Forms.TextBox();
            this.txtDateBooked = new System.Windows.Forms.TextBox();
            this.txtBookIdBooked = new System.Windows.Forms.TextBox();
            this.txtMemberIdBooked = new System.Windows.Forms.TextBox();
            this.monthCalendarBooked = new System.Windows.Forms.MonthCalendar();
            this.lblDueBooked = new System.Windows.Forms.Label();
            this.lblDateBooked = new System.Windows.Forms.Label();
            this.lblBookIdBooked = new System.Windows.Forms.Label();
            this.lblMemberIdBooked = new System.Windows.Forms.Label();
            this.btnCancelBooked = new System.Windows.Forms.Button();
            this.btnAddBooked = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAddBooked = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowseMembersBooked
            // 
            this.btnBrowseMembersBooked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnBrowseMembersBooked.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowseMembersBooked.ForeColor = System.Drawing.Color.White;
            this.btnBrowseMembersBooked.Location = new System.Drawing.Point(323, 92);
            this.btnBrowseMembersBooked.Name = "btnBrowseMembersBooked";
            this.btnBrowseMembersBooked.Size = new System.Drawing.Size(160, 33);
            this.btnBrowseMembersBooked.TabIndex = 28;
            this.btnBrowseMembersBooked.Text = "Browse Members";
            this.btnBrowseMembersBooked.UseVisualStyleBackColor = false;
            // 
            // btnBrowseBooksBooked
            // 
            this.btnBrowseBooksBooked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnBrowseBooksBooked.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowseBooksBooked.ForeColor = System.Drawing.Color.White;
            this.btnBrowseBooksBooked.Location = new System.Drawing.Point(323, 129);
            this.btnBrowseBooksBooked.Name = "btnBrowseBooksBooked";
            this.btnBrowseBooksBooked.Size = new System.Drawing.Size(160, 33);
            this.btnBrowseBooksBooked.TabIndex = 27;
            this.btnBrowseBooksBooked.Text = "Browse Books";
            this.btnBrowseBooksBooked.UseVisualStyleBackColor = false;
            // 
            // txtDueDateBooked
            // 
            this.txtDueDateBooked.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDueDateBooked.Location = new System.Drawing.Point(154, 204);
            this.txtDueDateBooked.Name = "txtDueDateBooked";
            this.txtDueDateBooked.ReadOnly = true;
            this.txtDueDateBooked.Size = new System.Drawing.Size(147, 26);
            this.txtDueDateBooked.TabIndex = 26;
            // 
            // txtDateBooked
            // 
            this.txtDateBooked.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDateBooked.Location = new System.Drawing.Point(154, 168);
            this.txtDateBooked.Name = "txtDateBooked";
            this.txtDateBooked.ReadOnly = true;
            this.txtDateBooked.Size = new System.Drawing.Size(147, 26);
            this.txtDateBooked.TabIndex = 25;
            // 
            // txtBookIdBooked
            // 
            this.txtBookIdBooked.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBookIdBooked.Location = new System.Drawing.Point(154, 132);
            this.txtBookIdBooked.Name = "txtBookIdBooked";
            this.txtBookIdBooked.ReadOnly = true;
            this.txtBookIdBooked.Size = new System.Drawing.Size(147, 26);
            this.txtBookIdBooked.TabIndex = 24;
            // 
            // txtMemberIdBooked
            // 
            this.txtMemberIdBooked.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMemberIdBooked.Location = new System.Drawing.Point(154, 96);
            this.txtMemberIdBooked.Name = "txtMemberIdBooked";
            this.txtMemberIdBooked.ReadOnly = true;
            this.txtMemberIdBooked.Size = new System.Drawing.Size(147, 26);
            this.txtMemberIdBooked.TabIndex = 23;
            // 
            // monthCalendarBooked
            // 
            this.monthCalendarBooked.Location = new System.Drawing.Point(34, 281);
            this.monthCalendarBooked.MaxSelectionCount = 1;
            this.monthCalendarBooked.Name = "monthCalendarBooked";
            this.monthCalendarBooked.TabIndex = 22;
            // 
            // lblDueBooked
            // 
            this.lblDueBooked.AutoSize = true;
            this.lblDueBooked.Location = new System.Drawing.Point(30, 207);
            this.lblDueBooked.Name = "lblDueBooked";
            this.lblDueBooked.Size = new System.Drawing.Size(75, 19);
            this.lblDueBooked.TabIndex = 21;
            this.lblDueBooked.Text = "Due Date*";
            // 
            // lblDateBooked
            // 
            this.lblDateBooked.AutoSize = true;
            this.lblDateBooked.Location = new System.Drawing.Point(30, 171);
            this.lblDateBooked.Name = "lblDateBooked";
            this.lblDateBooked.Size = new System.Drawing.Size(99, 19);
            this.lblDateBooked.TabIndex = 20;
            this.lblDateBooked.Text = "Date Booked*";
            // 
            // lblBookIdBooked
            // 
            this.lblBookIdBooked.AutoSize = true;
            this.lblBookIdBooked.Location = new System.Drawing.Point(30, 135);
            this.lblBookIdBooked.Name = "lblBookIdBooked";
            this.lblBookIdBooked.Size = new System.Drawing.Size(68, 19);
            this.lblBookIdBooked.TabIndex = 19;
            this.lblBookIdBooked.Text = "Book Id*";
            // 
            // lblMemberIdBooked
            // 
            this.lblMemberIdBooked.AutoSize = true;
            this.lblMemberIdBooked.Location = new System.Drawing.Point(30, 99);
            this.lblMemberIdBooked.Name = "lblMemberIdBooked";
            this.lblMemberIdBooked.Size = new System.Drawing.Size(86, 19);
            this.lblMemberIdBooked.TabIndex = 18;
            this.lblMemberIdBooked.Text = "Member Id*";
            // 
            // btnCancelBooked
            // 
            this.btnCancelBooked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnCancelBooked.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnCancelBooked.FlatAppearance.BorderSize = 2;
            this.btnCancelBooked.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnCancelBooked.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooked.Location = new System.Drawing.Point(383, 364);
            this.btnCancelBooked.Name = "btnCancelBooked";
            this.btnCancelBooked.Size = new System.Drawing.Size(100, 40);
            this.btnCancelBooked.TabIndex = 17;
            this.btnCancelBooked.Text = "Cancel";
            this.btnCancelBooked.UseVisualStyleBackColor = false;
            // 
            // btnAddBooked
            // 
            this.btnAddBooked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnAddBooked.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnAddBooked.FlatAppearance.BorderSize = 2;
            this.btnAddBooked.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAddBooked.ForeColor = System.Drawing.Color.White;
            this.btnAddBooked.Location = new System.Drawing.Point(383, 318);
            this.btnAddBooked.Name = "btnAddBooked";
            this.btnAddBooked.Size = new System.Drawing.Size(100, 40);
            this.btnAddBooked.TabIndex = 16;
            this.btnAddBooked.Text = "Add";
            this.btnAddBooked.UseVisualStyleBackColor = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(172)))));
            this.pnlTop.Controls.Add(this.lblAddBooked);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(483, 84);
            this.pnlTop.TabIndex = 29;
            // 
            // lblAddBooked
            // 
            this.lblAddBooked.AutoSize = true;
            this.lblAddBooked.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBooked.ForeColor = System.Drawing.Color.White;
            this.lblAddBooked.Location = new System.Drawing.Point(136, 23);
            this.lblAddBooked.Name = "lblAddBooked";
            this.lblAddBooked.Size = new System.Drawing.Size(243, 37);
            this.lblAddBooked.TabIndex = 0;
            this.lblAddBooked.Text = "Edit Booked Form";
            this.lblAddBooked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditBookedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnBrowseMembersBooked);
            this.Controls.Add(this.btnBrowseBooksBooked);
            this.Controls.Add(this.txtDueDateBooked);
            this.Controls.Add(this.txtDateBooked);
            this.Controls.Add(this.txtBookIdBooked);
            this.Controls.Add(this.txtMemberIdBooked);
            this.Controls.Add(this.monthCalendarBooked);
            this.Controls.Add(this.lblDueBooked);
            this.Controls.Add(this.lblDateBooked);
            this.Controls.Add(this.lblBookIdBooked);
            this.Controls.Add(this.lblMemberIdBooked);
            this.Controls.Add(this.btnCancelBooked);
            this.Controls.Add(this.btnAddBooked);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditBookedForm";
            this.Text = "EditBookedForm";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseMembersBooked;
        private System.Windows.Forms.Button btnBrowseBooksBooked;
        private System.Windows.Forms.TextBox txtDueDateBooked;
        private System.Windows.Forms.TextBox txtDateBooked;
        private System.Windows.Forms.TextBox txtBookIdBooked;
        private System.Windows.Forms.TextBox txtMemberIdBooked;
        private System.Windows.Forms.MonthCalendar monthCalendarBooked;
        private System.Windows.Forms.Label lblDueBooked;
        private System.Windows.Forms.Label lblDateBooked;
        private System.Windows.Forms.Label lblBookIdBooked;
        private System.Windows.Forms.Label lblMemberIdBooked;
        private System.Windows.Forms.Button btnCancelBooked;
        private System.Windows.Forms.Button btnAddBooked;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAddBooked;
    }
}