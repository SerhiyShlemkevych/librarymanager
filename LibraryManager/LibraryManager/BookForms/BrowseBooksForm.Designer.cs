namespace LibraryManager
{
    partial class BrowseBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseBooksForm));
            this.pnlMenuBooks = new System.Windows.Forms.Panel();
            this.btnCancelBrowesBooksBooked = new System.Windows.Forms.Button();
            this.cmbFilterBooks = new System.Windows.Forms.ComboBox();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.txtSearchBooks = new System.Windows.Forms.TextBox();
            this.btnGetId = new System.Windows.Forms.Button();
            this.pnlMainBooks = new System.Windows.Forms.Panel();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearPublished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenuBooks.SuspendLayout();
            this.pnlMainBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuBooks
            // 
            this.pnlMenuBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenuBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMenuBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(141)))), ((int)(((byte)(176)))));
            this.pnlMenuBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuBooks.Controls.Add(this.btnCancelBrowesBooksBooked);
            this.pnlMenuBooks.Controls.Add(this.cmbFilterBooks);
            this.pnlMenuBooks.Controls.Add(this.btnSearchBooks);
            this.pnlMenuBooks.Controls.Add(this.txtSearchBooks);
            this.pnlMenuBooks.Controls.Add(this.btnGetId);
            this.pnlMenuBooks.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBooks.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuBooks.Name = "pnlMenuBooks";
            this.pnlMenuBooks.Size = new System.Drawing.Size(633, 49);
            this.pnlMenuBooks.TabIndex = 10;
            // 
            // btnCancelBrowesBooksBooked
            // 
            this.btnCancelBrowesBooksBooked.BackColor = System.Drawing.Color.White;
            this.btnCancelBrowesBooksBooked.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelBrowesBooksBooked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBrowesBooksBooked.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBrowesBooksBooked.Location = new System.Drawing.Point(121, 8);
            this.btnCancelBrowesBooksBooked.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelBrowesBooksBooked.Name = "btnCancelBrowesBooksBooked";
            this.btnCancelBrowesBooksBooked.Size = new System.Drawing.Size(101, 29);
            this.btnCancelBrowesBooksBooked.TabIndex = 9;
            this.btnCancelBrowesBooksBooked.Text = "Cancel";
            this.btnCancelBrowesBooksBooked.UseVisualStyleBackColor = false;
            this.btnCancelBrowesBooksBooked.Click += new System.EventHandler(this.btnCancelBrowesBooksBooked_Click);
            // 
            // cmbFilterBooks
            // 
            this.cmbFilterBooks.FormattingEnabled = true;
            this.cmbFilterBooks.Items.AddRange(new object[] {
            "Name",
            "Author",
            "Genre",
            "YearPublished",
            "Publisher"});
            this.cmbFilterBooks.Location = new System.Drawing.Point(325, 10);
            this.cmbFilterBooks.Name = "cmbFilterBooks";
            this.cmbFilterBooks.Size = new System.Drawing.Size(125, 27);
            this.cmbFilterBooks.TabIndex = 8;
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.BackColor = System.Drawing.Color.White;
            this.btnSearchBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchBooks.BackgroundImage")));
            this.btnSearchBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchBooks.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchBooks.Location = new System.Drawing.Point(599, 10);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(25, 26);
            this.btnSearchBooks.TabIndex = 7;
            this.btnSearchBooks.UseVisualStyleBackColor = false;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            // 
            // txtSearchBooks
            // 
            this.txtSearchBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBooks.Location = new System.Drawing.Point(456, 11);
            this.txtSearchBooks.Name = "txtSearchBooks";
            this.txtSearchBooks.Size = new System.Drawing.Size(140, 26);
            this.txtSearchBooks.TabIndex = 6;
            // 
            // btnGetId
            // 
            this.btnGetId.BackColor = System.Drawing.Color.White;
            this.btnGetId.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGetId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetId.Location = new System.Drawing.Point(12, 8);
            this.btnGetId.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetId.Name = "btnGetId";
            this.btnGetId.Size = new System.Drawing.Size(101, 29);
            this.btnGetId.TabIndex = 5;
            this.btnGetId.Text = "Select";
            this.btnGetId.UseVisualStyleBackColor = false;
            this.btnGetId.Click += new System.EventHandler(this.btnGetId_Click);
            // 
            // pnlMainBooks
            // 
            this.pnlMainBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMainBooks.BackColor = System.Drawing.Color.White;
            this.pnlMainBooks.Controls.Add(this.dataGridViewBooks);
            this.pnlMainBooks.Location = new System.Drawing.Point(0, 46);
            this.pnlMainBooks.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMainBooks.Name = "pnlMainBooks";
            this.pnlMainBooks.Size = new System.Drawing.Size(634, 320);
            this.pnlMainBooks.TabIndex = 8;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToResizeRows = false;
            this.dataGridViewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.Author,
            this.Genre,
            this.YearPublished,
            this.Publisher});
            this.dataGridViewBooks.GridColor = System.Drawing.Color.White;
            this.dataGridViewBooks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBooks.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.Size = new System.Drawing.Size(633, 320);
            this.dataGridViewBooks.TabIndex = 0;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "Name";
            this.BookName.HeaderText = "Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // YearPublished
            // 
            this.YearPublished.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.YearPublished.DataPropertyName = "YearPublished";
            this.YearPublished.FillWeight = 20F;
            this.YearPublished.HeaderText = "Year ";
            this.YearPublished.Name = "YearPublished";
            this.YearPublished.ReadOnly = true;
            this.YearPublished.Width = 66;
            // 
            // Publisher
            // 
            this.Publisher.DataPropertyName = "Publisher";
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // BrowseBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.pnlMenuBooks);
            this.Controls.Add(this.pnlMainBooks);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BrowseBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse Books Form";
            this.pnlMenuBooks.ResumeLayout(false);
            this.pnlMenuBooks.PerformLayout();
            this.pnlMainBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuBooks;
        private System.Windows.Forms.Panel pnlMainBooks;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearPublished;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.Button btnGetId;
        private System.Windows.Forms.ComboBox cmbFilterBooks;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.TextBox txtSearchBooks;
        private System.Windows.Forms.Button btnCancelBrowesBooksBooked;
    }
}