namespace LibraryManager
{
    partial class SetFineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetFineForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblSetFine = new System.Windows.Forms.Label();
            this.lblFineBooked = new System.Windows.Forms.Label();
            this.txtFineBooked = new System.Windows.Forms.TextBox();
            this.txtDueDateBooked = new System.Windows.Forms.TextBox();
            this.txtDateBooked = new System.Windows.Forms.TextBox();
            this.lblDueBooked = new System.Windows.Forms.Label();
            this.lblDateBooked = new System.Windows.Forms.Label();
            this.txtDaysOverBooked = new System.Windows.Forms.TextBox();
            this.lblDaysBooked = new System.Windows.Forms.Label();
            this.txtResultBooked = new System.Windows.Forms.TextBox();
            this.lblResultBooked = new System.Windows.Forms.Label();
            this.btnCancelBooked = new System.Windows.Forms.Button();
            this.btnAddFineBooked = new System.Windows.Forms.Button();
            this.btnCountBooked = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(172)))));
            this.pnlTop.Controls.Add(this.lblSetFine);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(583, 72);
            this.pnlTop.TabIndex = 14;
            // 
            // lblSetFine
            // 
            this.lblSetFine.AutoSize = true;
            this.lblSetFine.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetFine.ForeColor = System.Drawing.Color.White;
            this.lblSetFine.Location = new System.Drawing.Point(173, 21);
            this.lblSetFine.Name = "lblSetFine";
            this.lblSetFine.Size = new System.Drawing.Size(192, 37);
            this.lblSetFine.TabIndex = 0;
            this.lblSetFine.Text = "Set Fine Form";
            this.lblSetFine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFineBooked
            // 
            this.lblFineBooked.AutoSize = true;
            this.lblFineBooked.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFineBooked.Location = new System.Drawing.Point(317, 95);
            this.lblFineBooked.Name = "lblFineBooked";
            this.lblFineBooked.Size = new System.Drawing.Size(144, 21);
            this.lblFineBooked.TabIndex = 15;
            this.lblFineBooked.Text = "Set Fine (per day)";
            // 
            // txtFineBooked
            // 
            this.txtFineBooked.Location = new System.Drawing.Point(321, 119);
            this.txtFineBooked.Name = "txtFineBooked";
            this.txtFineBooked.Size = new System.Drawing.Size(140, 26);
            this.txtFineBooked.TabIndex = 16;
            // 
            // txtDueDateBooked
            // 
            this.txtDueDateBooked.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDueDateBooked.Location = new System.Drawing.Point(143, 137);
            this.txtDueDateBooked.Name = "txtDueDateBooked";
            this.txtDueDateBooked.ReadOnly = true;
            this.txtDueDateBooked.Size = new System.Drawing.Size(147, 26);
            this.txtDueDateBooked.TabIndex = 30;
            // 
            // txtDateBooked
            // 
            this.txtDateBooked.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDateBooked.Location = new System.Drawing.Point(143, 101);
            this.txtDateBooked.Name = "txtDateBooked";
            this.txtDateBooked.ReadOnly = true;
            this.txtDateBooked.Size = new System.Drawing.Size(147, 26);
            this.txtDateBooked.TabIndex = 29;
            // 
            // lblDueBooked
            // 
            this.lblDueBooked.AutoSize = true;
            this.lblDueBooked.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDueBooked.Location = new System.Drawing.Point(19, 140);
            this.lblDueBooked.Name = "lblDueBooked";
            this.lblDueBooked.Size = new System.Drawing.Size(79, 21);
            this.lblDueBooked.TabIndex = 28;
            this.lblDueBooked.Text = "Due Date";
            // 
            // lblDateBooked
            // 
            this.lblDateBooked.AutoSize = true;
            this.lblDateBooked.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateBooked.Location = new System.Drawing.Point(19, 104);
            this.lblDateBooked.Name = "lblDateBooked";
            this.lblDateBooked.Size = new System.Drawing.Size(108, 21);
            this.lblDateBooked.TabIndex = 27;
            this.lblDateBooked.Text = "Date Booked";
            // 
            // txtDaysOverBooked
            // 
            this.txtDaysOverBooked.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDaysOverBooked.Location = new System.Drawing.Point(143, 172);
            this.txtDaysOverBooked.Name = "txtDaysOverBooked";
            this.txtDaysOverBooked.ReadOnly = true;
            this.txtDaysOverBooked.Size = new System.Drawing.Size(147, 26);
            this.txtDaysOverBooked.TabIndex = 32;
            // 
            // lblDaysBooked
            // 
            this.lblDaysBooked.AutoSize = true;
            this.lblDaysBooked.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDaysBooked.Location = new System.Drawing.Point(19, 177);
            this.lblDaysBooked.Name = "lblDaysBooked";
            this.lblDaysBooked.Size = new System.Drawing.Size(113, 21);
            this.lblDaysBooked.TabIndex = 31;
            this.lblDaysBooked.Text = "Days overdue";
            // 
            // txtResultBooked
            // 
            this.txtResultBooked.Location = new System.Drawing.Point(321, 172);
            this.txtResultBooked.Name = "txtResultBooked";
            this.txtResultBooked.ReadOnly = true;
            this.txtResultBooked.Size = new System.Drawing.Size(140, 26);
            this.txtResultBooked.TabIndex = 34;
            // 
            // lblResultBooked
            // 
            this.lblResultBooked.AutoSize = true;
            this.lblResultBooked.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultBooked.Location = new System.Drawing.Point(345, 148);
            this.lblResultBooked.Name = "lblResultBooked";
            this.lblResultBooked.Size = new System.Drawing.Size(94, 21);
            this.lblResultBooked.TabIndex = 33;
            this.lblResultBooked.Text = "Result Fine";
            // 
            // btnCancelBooked
            // 
            this.btnCancelBooked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnCancelBooked.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnCancelBooked.FlatAppearance.BorderSize = 2;
            this.btnCancelBooked.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnCancelBooked.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooked.Location = new System.Drawing.Point(143, 243);
            this.btnCancelBooked.Name = "btnCancelBooked";
            this.btnCancelBooked.Size = new System.Drawing.Size(100, 40);
            this.btnCancelBooked.TabIndex = 36;
            this.btnCancelBooked.Text = "Cancel";
            this.btnCancelBooked.UseVisualStyleBackColor = false;
            this.btnCancelBooked.Click += new System.EventHandler(this.btnCancelBooked_Click);
            // 
            // btnAddFineBooked
            // 
            this.btnAddFineBooked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnAddFineBooked.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnAddFineBooked.FlatAppearance.BorderSize = 2;
            this.btnAddFineBooked.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAddFineBooked.ForeColor = System.Drawing.Color.White;
            this.btnAddFineBooked.Location = new System.Drawing.Point(22, 243);
            this.btnAddFineBooked.Name = "btnAddFineBooked";
            this.btnAddFineBooked.Size = new System.Drawing.Size(100, 40);
            this.btnAddFineBooked.TabIndex = 35;
            this.btnAddFineBooked.Text = "Add Fine";
            this.btnAddFineBooked.UseVisualStyleBackColor = false;
            this.btnAddFineBooked.Click += new System.EventHandler(this.btnAddFineBooked_Click);
            // 
            // btnCountBooked
            // 
            this.btnCountBooked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnCountBooked.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnCountBooked.FlatAppearance.BorderSize = 2;
            this.btnCountBooked.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnCountBooked.ForeColor = System.Drawing.Color.White;
            this.btnCountBooked.Location = new System.Drawing.Point(339, 243);
            this.btnCountBooked.Name = "btnCountBooked";
            this.btnCountBooked.Size = new System.Drawing.Size(100, 40);
            this.btnCountBooked.TabIndex = 37;
            this.btnCountBooked.Text = "Count Fine";
            this.btnCountBooked.UseVisualStyleBackColor = false;
            this.btnCountBooked.Click += new System.EventHandler(this.btnCountBooked_Click);
            // 
            // SetFineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btnCountBooked);
            this.Controls.Add(this.btnCancelBooked);
            this.Controls.Add(this.btnAddFineBooked);
            this.Controls.Add(this.txtResultBooked);
            this.Controls.Add(this.lblResultBooked);
            this.Controls.Add(this.txtDaysOverBooked);
            this.Controls.Add(this.lblDaysBooked);
            this.Controls.Add(this.txtDueDateBooked);
            this.Controls.Add(this.txtDateBooked);
            this.Controls.Add(this.lblDueBooked);
            this.Controls.Add(this.lblDateBooked);
            this.Controls.Add(this.txtFineBooked);
            this.Controls.Add(this.lblFineBooked);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SetFineForm";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSetFine;
        private System.Windows.Forms.Label lblFineBooked;
        private System.Windows.Forms.TextBox txtFineBooked;
        private System.Windows.Forms.TextBox txtDueDateBooked;
        private System.Windows.Forms.TextBox txtDateBooked;
        private System.Windows.Forms.Label lblDueBooked;
        private System.Windows.Forms.Label lblDateBooked;
        private System.Windows.Forms.TextBox txtDaysOverBooked;
        private System.Windows.Forms.Label lblDaysBooked;
        private System.Windows.Forms.TextBox txtResultBooked;
        private System.Windows.Forms.Label lblResultBooked;
        private System.Windows.Forms.Button btnCancelBooked;
        private System.Windows.Forms.Button btnAddFineBooked;
        private System.Windows.Forms.Button btnCountBooked;
    }
}