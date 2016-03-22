namespace LibraryManager
{
    partial class AddBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAddBook = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnCancelBook = new System.Windows.Forms.Button();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.lblAuthorBook = new System.Windows.Forms.Label();
            this.lblYearPublished = new System.Windows.Forms.Label();
            this.lblPublisherBook = new System.Windows.Forms.Label();
            this.lblGenreBook = new System.Windows.Forms.Label();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.txtAuthorBook = new System.Windows.Forms.TextBox();
            this.txtYearBook = new System.Windows.Forms.TextBox();
            this.txtPublisherBook = new System.Windows.Forms.TextBox();
            this.txtGenreBook = new System.Windows.Forms.TextBox();
            this.btnBrowsePhotoBook = new System.Windows.Forms.Button();
            this.pcBPhotoBook = new System.Windows.Forms.PictureBox();
            this.lblAmountBook = new System.Windows.Forms.Label();
            this.txtAmountBook = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBPhotoBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(172)))));
            this.pnlTop.Controls.Add(this.lblAddBook);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(483, 84);
            this.pnlTop.TabIndex = 0;
            // 
            // lblAddBook
            // 
            this.lblAddBook.AutoSize = true;
            this.lblAddBook.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBook.ForeColor = System.Drawing.Color.White;
            this.lblAddBook.Location = new System.Drawing.Point(136, 23);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(213, 37);
            this.lblAddBook.TabIndex = 0;
            this.lblAddBook.Text = "Add Book Form";
            this.lblAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnAddBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnAddBook.FlatAppearance.BorderSize = 2;
            this.btnAddBook.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(131, 409);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 40);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnCancelBook
            // 
            this.btnCancelBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnCancelBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnCancelBook.FlatAppearance.BorderSize = 2;
            this.btnCancelBook.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnCancelBook.ForeColor = System.Drawing.Color.White;
            this.btnCancelBook.Location = new System.Drawing.Point(271, 409);
            this.btnCancelBook.Name = "btnCancelBook";
            this.btnCancelBook.Size = new System.Drawing.Size(100, 40);
            this.btnCancelBook.TabIndex = 2;
            this.btnCancelBook.Text = "Cancel";
            this.btnCancelBook.UseVisualStyleBackColor = false;
            this.btnCancelBook.Click += new System.EventHandler(this.btnCancelBook_Click);
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameBook.Location = new System.Drawing.Point(32, 162);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(62, 21);
            this.lblNameBook.TabIndex = 3;
            this.lblNameBook.Text = "Name*";
            // 
            // lblAuthorBook
            // 
            this.lblAuthorBook.AutoSize = true;
            this.lblAuthorBook.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthorBook.Location = new System.Drawing.Point(32, 194);
            this.lblAuthorBook.Name = "lblAuthorBook";
            this.lblAuthorBook.Size = new System.Drawing.Size(71, 21);
            this.lblAuthorBook.TabIndex = 4;
            this.lblAuthorBook.Text = "Author*";
            // 
            // lblYearPublished
            // 
            this.lblYearPublished.AutoSize = true;
            this.lblYearPublished.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYearPublished.Location = new System.Drawing.Point(32, 226);
            this.lblYearPublished.Name = "lblYearPublished";
            this.lblYearPublished.Size = new System.Drawing.Size(43, 21);
            this.lblYearPublished.TabIndex = 5;
            this.lblYearPublished.Text = "Year";
            // 
            // lblPublisherBook
            // 
            this.lblPublisherBook.AutoSize = true;
            this.lblPublisherBook.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPublisherBook.Location = new System.Drawing.Point(32, 255);
            this.lblPublisherBook.Name = "lblPublisherBook";
            this.lblPublisherBook.Size = new System.Drawing.Size(79, 21);
            this.lblPublisherBook.TabIndex = 6;
            this.lblPublisherBook.Text = "Publisher";
            // 
            // lblGenreBook
            // 
            this.lblGenreBook.AutoSize = true;
            this.lblGenreBook.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGenreBook.Location = new System.Drawing.Point(32, 289);
            this.lblGenreBook.Name = "lblGenreBook";
            this.lblGenreBook.Size = new System.Drawing.Size(55, 21);
            this.lblGenreBook.TabIndex = 7;
            this.lblGenreBook.Text = "Genre";
            // 
            // txtNameBook
            // 
            this.txtNameBook.Location = new System.Drawing.Point(115, 160);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.Size = new System.Drawing.Size(159, 26);
            this.txtNameBook.TabIndex = 8;
            // 
            // txtAuthorBook
            // 
            this.txtAuthorBook.Location = new System.Drawing.Point(115, 192);
            this.txtAuthorBook.Name = "txtAuthorBook";
            this.txtAuthorBook.Size = new System.Drawing.Size(159, 26);
            this.txtAuthorBook.TabIndex = 9;
            // 
            // txtYearBook
            // 
            this.txtYearBook.Location = new System.Drawing.Point(115, 224);
            this.txtYearBook.Name = "txtYearBook";
            this.txtYearBook.Size = new System.Drawing.Size(159, 26);
            this.txtYearBook.TabIndex = 10;
            // 
            // txtPublisherBook
            // 
            this.txtPublisherBook.Location = new System.Drawing.Point(115, 256);
            this.txtPublisherBook.Name = "txtPublisherBook";
            this.txtPublisherBook.Size = new System.Drawing.Size(159, 26);
            this.txtPublisherBook.TabIndex = 11;
            // 
            // txtGenreBook
            // 
            this.txtGenreBook.Location = new System.Drawing.Point(115, 287);
            this.txtGenreBook.Name = "txtGenreBook";
            this.txtGenreBook.Size = new System.Drawing.Size(159, 26);
            this.txtGenreBook.TabIndex = 12;
            // 
            // btnBrowsePhotoBook
            // 
            this.btnBrowsePhotoBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnBrowsePhotoBook.ForeColor = System.Drawing.Color.White;
            this.btnBrowsePhotoBook.Location = new System.Drawing.Point(329, 290);
            this.btnBrowsePhotoBook.Name = "btnBrowsePhotoBook";
            this.btnBrowsePhotoBook.Size = new System.Drawing.Size(115, 45);
            this.btnBrowsePhotoBook.TabIndex = 33;
            this.btnBrowsePhotoBook.Text = "Browse";
            this.btnBrowsePhotoBook.UseVisualStyleBackColor = false;
            this.btnBrowsePhotoBook.Click += new System.EventHandler(this.btnBrowsePhotoBook_Click);
            // 
            // pcBPhotoBook
            // 
            this.pcBPhotoBook.BackColor = System.Drawing.Color.White;
            this.pcBPhotoBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcBPhotoBook.Location = new System.Drawing.Point(329, 126);
            this.pcBPhotoBook.Name = "pcBPhotoBook";
            this.pcBPhotoBook.Size = new System.Drawing.Size(115, 150);
            this.pcBPhotoBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBPhotoBook.TabIndex = 32;
            this.pcBPhotoBook.TabStop = false;
            // 
            // lblAmountBook
            // 
            this.lblAmountBook.AutoSize = true;
            this.lblAmountBook.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmountBook.Location = new System.Drawing.Point(32, 321);
            this.lblAmountBook.Name = "lblAmountBook";
            this.lblAmountBook.Size = new System.Drawing.Size(70, 21);
            this.lblAmountBook.TabIndex = 34;
            this.lblAmountBook.Text = "Amount";
            // 
            // txtAmountBook
            // 
            this.txtAmountBook.Location = new System.Drawing.Point(115, 319);
            this.txtAmountBook.Name = "txtAmountBook";
            this.txtAmountBook.Size = new System.Drawing.Size(159, 26);
            this.txtAmountBook.TabIndex = 35;
            this.txtAmountBook.Text = "1";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txtAmountBook);
            this.Controls.Add(this.lblAmountBook);
            this.Controls.Add(this.btnBrowsePhotoBook);
            this.Controls.Add(this.pcBPhotoBook);
            this.Controls.Add(this.txtGenreBook);
            this.Controls.Add(this.txtPublisherBook);
            this.Controls.Add(this.txtYearBook);
            this.Controls.Add(this.txtAuthorBook);
            this.Controls.Add(this.txtNameBook);
            this.Controls.Add(this.lblGenreBook);
            this.Controls.Add(this.lblPublisherBook);
            this.Controls.Add(this.lblYearPublished);
            this.Controls.Add(this.lblAuthorBook);
            this.Controls.Add(this.lblNameBook);
            this.Controls.Add(this.btnCancelBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBPhotoBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAddBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnCancelBook;
        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.Label lblAuthorBook;
        private System.Windows.Forms.Label lblYearPublished;
        private System.Windows.Forms.Label lblPublisherBook;
        private System.Windows.Forms.Label lblGenreBook;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.TextBox txtAuthorBook;
        private System.Windows.Forms.TextBox txtYearBook;
        private System.Windows.Forms.TextBox txtPublisherBook;
        private System.Windows.Forms.TextBox txtGenreBook;
        private System.Windows.Forms.Button btnBrowsePhotoBook;
        private System.Windows.Forms.PictureBox pcBPhotoBook;
        private System.Windows.Forms.Label lblAmountBook;
        private System.Windows.Forms.TextBox txtAmountBook;
    }
}