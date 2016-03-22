namespace LibraryManager
{
    partial class BrowseMembersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseMembersForm));
            this.pnlMainMembers = new System.Windows.Forms.Panel();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.PassportId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfMembership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenuMembers = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGetPassport = new System.Windows.Forms.Button();
            this.cmbFilterMembers = new System.Windows.Forms.ComboBox();
            this.btnSearchMembers = new System.Windows.Forms.Button();
            this.txtSearchMembers = new System.Windows.Forms.TextBox();
            this.pnlMainMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.pnlMenuMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainMembers
            // 
            this.pnlMainMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainMembers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMainMembers.BackColor = System.Drawing.Color.White;
            this.pnlMainMembers.Controls.Add(this.dataGridViewMembers);
            this.pnlMainMembers.Location = new System.Drawing.Point(0, 40);
            this.pnlMainMembers.Name = "pnlMainMembers";
            this.pnlMainMembers.Size = new System.Drawing.Size(634, 325);
            this.pnlMainMembers.TabIndex = 12;
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.AllowUserToOrderColumns = true;
            this.dataGridViewMembers.AllowUserToResizeRows = false;
            this.dataGridViewMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMembers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMembers.ColumnHeadersHeight = 26;
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PassportId,
            this.FirstName,
            this.SecondName,
            this.DateOfMembership});
            this.dataGridViewMembers.GridColor = System.Drawing.Color.White;
            this.dataGridViewMembers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMembers.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.ReadOnly = true;
            this.dataGridViewMembers.Size = new System.Drawing.Size(634, 325);
            this.dataGridViewMembers.TabIndex = 0;
            // 
            // PassportId
            // 
            this.PassportId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PassportId.DataPropertyName = "PassportId";
            this.PassportId.HeaderText = "Passport";
            this.PassportId.Name = "PassportId";
            this.PassportId.ReadOnly = true;
            this.PassportId.Width = 101;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // SecondName
            // 
            this.SecondName.DataPropertyName = "SecondName";
            this.SecondName.HeaderText = "Surname";
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            // 
            // DateOfMembership
            // 
            this.DateOfMembership.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfMembership.DataPropertyName = "DateOfMembership";
            this.DateOfMembership.HeaderText = "Register Date";
            this.DateOfMembership.Name = "DateOfMembership";
            this.DateOfMembership.ReadOnly = true;
            // 
            // pnlMenuMembers
            // 
            this.pnlMenuMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenuMembers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMenuMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(141)))), ((int)(((byte)(176)))));
            this.pnlMenuMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuMembers.Controls.Add(this.btnCancel);
            this.pnlMenuMembers.Controls.Add(this.btnGetPassport);
            this.pnlMenuMembers.Controls.Add(this.cmbFilterMembers);
            this.pnlMenuMembers.Controls.Add(this.btnSearchMembers);
            this.pnlMenuMembers.Controls.Add(this.txtSearchMembers);
            this.pnlMenuMembers.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuMembers.Name = "pnlMenuMembers";
            this.pnlMenuMembers.Size = new System.Drawing.Size(634, 40);
            this.pnlMenuMembers.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(99, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGetPassport
            // 
            this.btnGetPassport.BackColor = System.Drawing.Color.White;
            this.btnGetPassport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGetPassport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetPassport.Location = new System.Drawing.Point(11, 5);
            this.btnGetPassport.Name = "btnGetPassport";
            this.btnGetPassport.Size = new System.Drawing.Size(82, 28);
            this.btnGetPassport.TabIndex = 6;
            this.btnGetPassport.Text = "Select";
            this.btnGetPassport.UseVisualStyleBackColor = false;
            this.btnGetPassport.Click += new System.EventHandler(this.btnGetPassport_Click);
            // 
            // cmbFilterMembers
            // 
            this.cmbFilterMembers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbFilterMembers.FormattingEnabled = true;
            this.cmbFilterMembers.Items.AddRange(new object[] {
            "FirstName",
            "SecondName",
            "PassportId",
            "DateOfMembership",
            "Phone",
            "Address",
            "Email"});
            this.cmbFilterMembers.Location = new System.Drawing.Point(317, 7);
            this.cmbFilterMembers.Name = "cmbFilterMembers";
            this.cmbFilterMembers.Size = new System.Drawing.Size(125, 27);
            this.cmbFilterMembers.TabIndex = 4;
            // 
            // btnSearchMembers
            // 
            this.btnSearchMembers.BackColor = System.Drawing.Color.White;
            this.btnSearchMembers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchMembers.BackgroundImage")));
            this.btnSearchMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchMembers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchMembers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchMembers.Location = new System.Drawing.Point(594, 8);
            this.btnSearchMembers.Name = "btnSearchMembers";
            this.btnSearchMembers.Size = new System.Drawing.Size(25, 26);
            this.btnSearchMembers.TabIndex = 1;
            this.btnSearchMembers.UseVisualStyleBackColor = false;
            this.btnSearchMembers.Click += new System.EventHandler(this.btnSearchMembers_Click);
            // 
            // txtSearchMembers
            // 
            this.txtSearchMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMembers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchMembers.Location = new System.Drawing.Point(448, 8);
            this.txtSearchMembers.Name = "txtSearchMembers";
            this.txtSearchMembers.Size = new System.Drawing.Size(140, 26);
            this.txtSearchMembers.TabIndex = 0;
            // 
            // BrowseMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.pnlMainMembers);
            this.Controls.Add(this.pnlMenuMembers);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BrowseMembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse Members Form";
            this.pnlMainMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.pnlMenuMembers.ResumeLayout(false);
            this.pnlMenuMembers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMembers;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfMembership;
        private System.Windows.Forms.Panel pnlMenuMembers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGetPassport;
        private System.Windows.Forms.ComboBox cmbFilterMembers;
        private System.Windows.Forms.Button btnSearchMembers;
        private System.Windows.Forms.TextBox txtSearchMembers;
    }
}