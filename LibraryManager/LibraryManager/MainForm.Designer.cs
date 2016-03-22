namespace LibraryManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tPgBooks = new System.Windows.Forms.TabPage();
            this.pnlMenuBooks = new System.Windows.Forms.Panel();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.cmbFilterBooks = new System.Windows.Forms.ComboBox();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.txtSearchBooks = new System.Windows.Forms.TextBox();
            this.pnlInfoBooks = new System.Windows.Forms.Panel();
            this.lstBBookAllInfo = new System.Windows.Forms.ListBox();
            this.pcBBook = new System.Windows.Forms.PictureBox();
            this.pnlMainBooks = new System.Windows.Forms.Panel();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearPublished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPgBooked = new System.Windows.Forms.TabPage();
            this.pnlMainBooked = new System.Windows.Forms.Panel();
            this.dataGridViewBooked = new System.Windows.Forms.DataGridView();
            this.pnlMenuBooked = new System.Windows.Forms.Panel();
            this.btnSetFineBooked = new System.Windows.Forms.Button();
            this.btnCancelBooked = new System.Windows.Forms.Button();
            this.btnAddBooked = new System.Windows.Forms.Button();
            this.cmbFilterBooked = new System.Windows.Forms.ComboBox();
            this.btnSerchBooked = new System.Windows.Forms.Button();
            this.txtSearchBooked = new System.Windows.Forms.TextBox();
            this.pnlInfoBooked = new System.Windows.Forms.Panel();
            this.lstBBookedAllInfo = new System.Windows.Forms.ListBox();
            this.tPgMembers = new System.Windows.Forms.TabPage();
            this.pnlMainMembers = new System.Windows.Forms.Panel();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.PassportId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfMembership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInfoMembers = new System.Windows.Forms.Panel();
            this.lstBMemberAllInfo = new System.Windows.Forms.ListBox();
            this.pcBMemberPhoto = new System.Windows.Forms.PictureBox();
            this.pnlMenuMembers = new System.Windows.Forms.Panel();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.cmbFilterMembers = new System.Windows.Forms.ComboBox();
            this.btnSearchMembers = new System.Windows.Forms.Button();
            this.txtSearchMembers = new System.Windows.Forms.TextBox();
            this.MainTabControl.SuspendLayout();
            this.tPgBooks.SuspendLayout();
            this.pnlMenuBooks.SuspendLayout();
            this.pnlInfoBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBBook)).BeginInit();
            this.pnlMainBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.tPgBooked.SuspendLayout();
            this.pnlMainBooked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooked)).BeginInit();
            this.pnlMenuBooked.SuspendLayout();
            this.pnlInfoBooked.SuspendLayout();
            this.tPgMembers.SuspendLayout();
            this.pnlMainMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.pnlInfoMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBMemberPhoto)).BeginInit();
            this.pnlMenuMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tPgBooks);
            this.MainTabControl.Controls.Add(this.tPgBooked);
            this.MainTabControl.Controls.Add(this.tPgMembers);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(884, 461);
            this.MainTabControl.TabIndex = 0;
            // 
            // tPgBooks
            // 
            this.tPgBooks.BackColor = System.Drawing.Color.White;
            this.tPgBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tPgBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPgBooks.Controls.Add(this.pnlMenuBooks);
            this.tPgBooks.Controls.Add(this.pnlInfoBooks);
            this.tPgBooks.Controls.Add(this.pnlMainBooks);
            this.tPgBooks.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tPgBooks.Location = new System.Drawing.Point(4, 28);
            this.tPgBooks.Name = "tPgBooks";
            this.tPgBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tPgBooks.Size = new System.Drawing.Size(876, 429);
            this.tPgBooks.TabIndex = 0;
            this.tPgBooks.Text = "Books";
            // 
            // pnlMenuBooks
            // 
            this.pnlMenuBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenuBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMenuBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(141)))), ((int)(((byte)(176)))));
            this.pnlMenuBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuBooks.Controls.Add(this.btnEditBook);
            this.pnlMenuBooks.Controls.Add(this.btnAddBook);
            this.pnlMenuBooks.Controls.Add(this.cmbFilterBooks);
            this.pnlMenuBooks.Controls.Add(this.btnSearchBooks);
            this.pnlMenuBooks.Controls.Add(this.txtSearchBooks);
            this.pnlMenuBooks.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBooks.Name = "pnlMenuBooks";
            this.pnlMenuBooks.Size = new System.Drawing.Size(879, 40);
            this.pnlMenuBooks.TabIndex = 7;
            // 
            // btnEditBook
            // 
            this.btnEditBook.BackColor = System.Drawing.Color.White;
            this.btnEditBook.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBook.Location = new System.Drawing.Point(132, 5);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(120, 28);
            this.btnEditBook.TabIndex = 8;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.White;
            this.btnAddBook.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Location = new System.Drawing.Point(6, 5);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(120, 28);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
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
            this.cmbFilterBooks.Location = new System.Drawing.Point(572, 7);
            this.cmbFilterBooks.Name = "cmbFilterBooks";
            this.cmbFilterBooks.Size = new System.Drawing.Size(125, 27);
            this.cmbFilterBooks.TabIndex = 4;
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.BackColor = System.Drawing.Color.White;
            this.btnSearchBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchBooks.BackgroundImage")));
            this.btnSearchBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchBooks.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchBooks.Location = new System.Drawing.Point(846, 7);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(25, 26);
            this.btnSearchBooks.TabIndex = 1;
            this.btnSearchBooks.UseVisualStyleBackColor = false;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            // 
            // txtSearchBooks
            // 
            this.txtSearchBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBooks.Location = new System.Drawing.Point(703, 8);
            this.txtSearchBooks.Name = "txtSearchBooks";
            this.txtSearchBooks.Size = new System.Drawing.Size(140, 26);
            this.txtSearchBooks.TabIndex = 0;
            this.txtSearchBooks.Validating += new System.ComponentModel.CancelEventHandler(this.txtSearchBooks_Validating);
            // 
            // pnlInfoBooks
            // 
            this.pnlInfoBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInfoBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlInfoBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(141)))), ((int)(((byte)(176)))));
            this.pnlInfoBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoBooks.Controls.Add(this.lstBBookAllInfo);
            this.pnlInfoBooks.Controls.Add(this.pcBBook);
            this.pnlInfoBooks.Location = new System.Drawing.Point(0, 43);
            this.pnlInfoBooks.Name = "pnlInfoBooks";
            this.pnlInfoBooks.Size = new System.Drawing.Size(223, 386);
            this.pnlInfoBooks.TabIndex = 5;
            // 
            // lstBBookAllInfo
            // 
            this.lstBBookAllInfo.FormattingEnabled = true;
            this.lstBBookAllInfo.ItemHeight = 19;
            this.lstBBookAllInfo.Location = new System.Drawing.Point(16, 173);
            this.lstBBookAllInfo.Name = "lstBBookAllInfo";
            this.lstBBookAllInfo.Size = new System.Drawing.Size(188, 194);
            this.lstBBookAllInfo.TabIndex = 3;
            // 
            // pcBBook
            // 
            this.pcBBook.BackColor = System.Drawing.Color.White;
            this.pcBBook.Location = new System.Drawing.Point(58, 17);
            this.pcBBook.Name = "pcBBook";
            this.pcBBook.Size = new System.Drawing.Size(115, 150);
            this.pcBBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBBook.TabIndex = 2;
            this.pcBBook.TabStop = false;
            // 
            // pnlMainBooks
            // 
            this.pnlMainBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMainBooks.BackColor = System.Drawing.Color.White;
            this.pnlMainBooks.Controls.Add(this.dataGridViewBooks);
            this.pnlMainBooks.Location = new System.Drawing.Point(226, 43);
            this.pnlMainBooks.Name = "pnlMainBooks";
            this.pnlMainBooks.Size = new System.Drawing.Size(650, 387);
            this.pnlMainBooks.TabIndex = 4;
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
            this.dataGridViewBooks.Size = new System.Drawing.Size(650, 390);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBooks_RowHeaderMouseClick);
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
            // tPgBooked
            // 
            this.tPgBooked.Controls.Add(this.pnlMainBooked);
            this.tPgBooked.Controls.Add(this.pnlMenuBooked);
            this.tPgBooked.Controls.Add(this.pnlInfoBooked);
            this.tPgBooked.Location = new System.Drawing.Point(4, 28);
            this.tPgBooked.Name = "tPgBooked";
            this.tPgBooked.Padding = new System.Windows.Forms.Padding(3);
            this.tPgBooked.Size = new System.Drawing.Size(876, 429);
            this.tPgBooked.TabIndex = 1;
            this.tPgBooked.Text = "Booked";
            this.tPgBooked.UseVisualStyleBackColor = true;
            // 
            // pnlMainBooked
            // 
            this.pnlMainBooked.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainBooked.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMainBooked.BackColor = System.Drawing.Color.White;
            this.pnlMainBooked.Controls.Add(this.dataGridViewBooked);
            this.pnlMainBooked.Location = new System.Drawing.Point(229, 43);
            this.pnlMainBooked.Name = "pnlMainBooked";
            this.pnlMainBooked.Size = new System.Drawing.Size(651, 390);
            this.pnlMainBooked.TabIndex = 10;
            // 
            // dataGridViewBooked
            // 
            this.dataGridViewBooked.AllowUserToResizeRows = false;
            this.dataGridViewBooked.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBooked.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooked.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBooked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooked.GridColor = System.Drawing.Color.White;
            this.dataGridViewBooked.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBooked.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewBooked.Name = "dataGridViewBooked";
            this.dataGridViewBooked.ReadOnly = true;
            this.dataGridViewBooked.Size = new System.Drawing.Size(647, 390);
            this.dataGridViewBooked.TabIndex = 0;
            this.dataGridViewBooked.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBooked_RowHeaderMouseClick);
            // 
            // pnlMenuBooked
            // 
            this.pnlMenuBooked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenuBooked.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMenuBooked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(141)))), ((int)(((byte)(176)))));
            this.pnlMenuBooked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuBooked.Controls.Add(this.btnSetFineBooked);
            this.pnlMenuBooked.Controls.Add(this.btnCancelBooked);
            this.pnlMenuBooked.Controls.Add(this.btnAddBooked);
            this.pnlMenuBooked.Controls.Add(this.cmbFilterBooked);
            this.pnlMenuBooked.Controls.Add(this.btnSerchBooked);
            this.pnlMenuBooked.Controls.Add(this.txtSearchBooked);
            this.pnlMenuBooked.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBooked.Name = "pnlMenuBooked";
            this.pnlMenuBooked.Size = new System.Drawing.Size(879, 40);
            this.pnlMenuBooked.TabIndex = 9;
            // 
            // btnSetFineBooked
            // 
            this.btnSetFineBooked.BackColor = System.Drawing.Color.White;
            this.btnSetFineBooked.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSetFineBooked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetFineBooked.Location = new System.Drawing.Point(258, 5);
            this.btnSetFineBooked.Name = "btnSetFineBooked";
            this.btnSetFineBooked.Size = new System.Drawing.Size(120, 28);
            this.btnSetFineBooked.TabIndex = 9;
            this.btnSetFineBooked.Text = "Set Fine";
            this.btnSetFineBooked.UseVisualStyleBackColor = false;
            this.btnSetFineBooked.Click += new System.EventHandler(this.btnSetFineBooked_Click);
            // 
            // btnCancelBooked
            // 
            this.btnCancelBooked.BackColor = System.Drawing.Color.White;
            this.btnCancelBooked.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelBooked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBooked.Location = new System.Drawing.Point(132, 5);
            this.btnCancelBooked.Name = "btnCancelBooked";
            this.btnCancelBooked.Size = new System.Drawing.Size(120, 28);
            this.btnCancelBooked.TabIndex = 8;
            this.btnCancelBooked.Text = "Cancel Booking";
            this.btnCancelBooked.UseVisualStyleBackColor = false;
            this.btnCancelBooked.Click += new System.EventHandler(this.btnCancelBooked_Click);
            // 
            // btnAddBooked
            // 
            this.btnAddBooked.BackColor = System.Drawing.Color.White;
            this.btnAddBooked.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddBooked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooked.Location = new System.Drawing.Point(6, 5);
            this.btnAddBooked.Name = "btnAddBooked";
            this.btnAddBooked.Size = new System.Drawing.Size(120, 28);
            this.btnAddBooked.TabIndex = 5;
            this.btnAddBooked.Text = "Add Booked";
            this.btnAddBooked.UseVisualStyleBackColor = false;
            this.btnAddBooked.Click += new System.EventHandler(this.btnAddBooked_Click);
            // 
            // cmbFilterBooked
            // 
            this.cmbFilterBooked.FormattingEnabled = true;
            this.cmbFilterBooked.Items.AddRange(new object[] {
            "BookedId",
            "PassportId",
            "Name",
            "DateBooked",
            "DueDate"});
            this.cmbFilterBooked.Location = new System.Drawing.Point(572, 7);
            this.cmbFilterBooked.Name = "cmbFilterBooked";
            this.cmbFilterBooked.Size = new System.Drawing.Size(125, 27);
            this.cmbFilterBooked.TabIndex = 4;
            // 
            // btnSerchBooked
            // 
            this.btnSerchBooked.BackColor = System.Drawing.Color.White;
            this.btnSerchBooked.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSerchBooked.BackgroundImage")));
            this.btnSerchBooked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerchBooked.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSerchBooked.Location = new System.Drawing.Point(846, 7);
            this.btnSerchBooked.Name = "btnSerchBooked";
            this.btnSerchBooked.Size = new System.Drawing.Size(25, 26);
            this.btnSerchBooked.TabIndex = 1;
            this.btnSerchBooked.UseVisualStyleBackColor = false;
            this.btnSerchBooked.Click += new System.EventHandler(this.btnSearchBooked_Click);
            // 
            // txtSearchBooked
            // 
            this.txtSearchBooked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBooked.Location = new System.Drawing.Point(703, 8);
            this.txtSearchBooked.Name = "txtSearchBooked";
            this.txtSearchBooked.Size = new System.Drawing.Size(140, 26);
            this.txtSearchBooked.TabIndex = 0;
            // 
            // pnlInfoBooked
            // 
            this.pnlInfoBooked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInfoBooked.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlInfoBooked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(141)))), ((int)(((byte)(176)))));
            this.pnlInfoBooked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoBooked.Controls.Add(this.lstBBookedAllInfo);
            this.pnlInfoBooked.Location = new System.Drawing.Point(0, 43);
            this.pnlInfoBooked.Name = "pnlInfoBooked";
            this.pnlInfoBooked.Size = new System.Drawing.Size(223, 386);
            this.pnlInfoBooked.TabIndex = 8;
            // 
            // lstBBookedAllInfo
            // 
            this.lstBBookedAllInfo.FormattingEnabled = true;
            this.lstBBookedAllInfo.ItemHeight = 19;
            this.lstBBookedAllInfo.Location = new System.Drawing.Point(16, 21);
            this.lstBBookedAllInfo.Name = "lstBBookedAllInfo";
            this.lstBBookedAllInfo.Size = new System.Drawing.Size(188, 346);
            this.lstBBookedAllInfo.TabIndex = 3;
            // 
            // tPgMembers
            // 
            this.tPgMembers.Controls.Add(this.pnlMainMembers);
            this.tPgMembers.Controls.Add(this.pnlInfoMembers);
            this.tPgMembers.Controls.Add(this.pnlMenuMembers);
            this.tPgMembers.Location = new System.Drawing.Point(4, 28);
            this.tPgMembers.Name = "tPgMembers";
            this.tPgMembers.Size = new System.Drawing.Size(876, 429);
            this.tPgMembers.TabIndex = 2;
            this.tPgMembers.Text = "Members";
            this.tPgMembers.UseVisualStyleBackColor = true;
            // 
            // pnlMainMembers
            // 
            this.pnlMainMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainMembers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMainMembers.BackColor = System.Drawing.Color.White;
            this.pnlMainMembers.Controls.Add(this.dataGridViewMembers);
            this.pnlMainMembers.Location = new System.Drawing.Point(229, 43);
            this.pnlMainMembers.Name = "pnlMainMembers";
            this.pnlMainMembers.Size = new System.Drawing.Size(651, 390);
            this.pnlMainMembers.TabIndex = 10;
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
            this.dataGridViewMembers.Size = new System.Drawing.Size(651, 393);
            this.dataGridViewMembers.TabIndex = 0;
            this.dataGridViewMembers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMembers_RowHeaderMouseClick);
            // 
            // PassportId
            // 
            this.PassportId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PassportId.DataPropertyName = "PassportId";
            this.PassportId.HeaderText = "Passport";
            this.PassportId.Name = "PassportId";
            this.PassportId.ReadOnly = true;
            this.PassportId.Width = 87;
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
            // pnlInfoMembers
            // 
            this.pnlInfoMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInfoMembers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlInfoMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(141)))), ((int)(((byte)(176)))));
            this.pnlInfoMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoMembers.Controls.Add(this.lstBMemberAllInfo);
            this.pnlInfoMembers.Controls.Add(this.pcBMemberPhoto);
            this.pnlInfoMembers.Location = new System.Drawing.Point(0, 43);
            this.pnlInfoMembers.Name = "pnlInfoMembers";
            this.pnlInfoMembers.Size = new System.Drawing.Size(223, 386);
            this.pnlInfoMembers.TabIndex = 9;
            // 
            // lstBMemberAllInfo
            // 
            this.lstBMemberAllInfo.FormattingEnabled = true;
            this.lstBMemberAllInfo.ItemHeight = 19;
            this.lstBMemberAllInfo.Location = new System.Drawing.Point(16, 171);
            this.lstBMemberAllInfo.Name = "lstBMemberAllInfo";
            this.lstBMemberAllInfo.Size = new System.Drawing.Size(188, 194);
            this.lstBMemberAllInfo.TabIndex = 1;
            // 
            // pcBMemberPhoto
            // 
            this.pcBMemberPhoto.BackColor = System.Drawing.Color.White;
            this.pcBMemberPhoto.Location = new System.Drawing.Point(58, 15);
            this.pcBMemberPhoto.Name = "pcBMemberPhoto";
            this.pcBMemberPhoto.Size = new System.Drawing.Size(115, 150);
            this.pcBMemberPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBMemberPhoto.TabIndex = 0;
            this.pcBMemberPhoto.TabStop = false;
            // 
            // pnlMenuMembers
            // 
            this.pnlMenuMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenuMembers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMenuMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(141)))), ((int)(((byte)(176)))));
            this.pnlMenuMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuMembers.Controls.Add(this.btnEditMember);
            this.pnlMenuMembers.Controls.Add(this.btnMember);
            this.pnlMenuMembers.Controls.Add(this.cmbFilterMembers);
            this.pnlMenuMembers.Controls.Add(this.btnSearchMembers);
            this.pnlMenuMembers.Controls.Add(this.txtSearchMembers);
            this.pnlMenuMembers.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuMembers.Name = "pnlMenuMembers";
            this.pnlMenuMembers.Size = new System.Drawing.Size(879, 40);
            this.pnlMenuMembers.TabIndex = 8;
            // 
            // btnEditMember
            // 
            this.btnEditMember.BackColor = System.Drawing.Color.White;
            this.btnEditMember.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMember.Location = new System.Drawing.Point(133, 6);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(120, 28);
            this.btnEditMember.TabIndex = 7;
            this.btnEditMember.Text = "Edit Member";
            this.btnEditMember.UseVisualStyleBackColor = false;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.White;
            this.btnMember.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Location = new System.Drawing.Point(7, 6);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(120, 28);
            this.btnMember.TabIndex = 6;
            this.btnMember.Text = "Add Member";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // cmbFilterMembers
            // 
            this.cmbFilterMembers.FormattingEnabled = true;
            this.cmbFilterMembers.Items.AddRange(new object[] {
            "FirstName",
            "SecondName",
            "PassportId",
            "DateOfMembership",
            "Phone",
            "Address",
            "Email"});
            this.cmbFilterMembers.Location = new System.Drawing.Point(572, 8);
            this.cmbFilterMembers.Name = "cmbFilterMembers";
            this.cmbFilterMembers.Size = new System.Drawing.Size(125, 27);
            this.cmbFilterMembers.TabIndex = 4;
            // 
            // btnSearchMembers
            // 
            this.btnSearchMembers.BackColor = System.Drawing.Color.White;
            this.btnSearchMembers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchMembers.BackgroundImage")));
            this.btnSearchMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchMembers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchMembers.Location = new System.Drawing.Point(846, 8);
            this.btnSearchMembers.Name = "btnSearchMembers";
            this.btnSearchMembers.Size = new System.Drawing.Size(25, 26);
            this.btnSearchMembers.TabIndex = 1;
            this.btnSearchMembers.UseVisualStyleBackColor = false;
            this.btnSearchMembers.Click += new System.EventHandler(this.btnSearchMembers_Click);
            // 
            // txtSearchMembers
            // 
            this.txtSearchMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMembers.Location = new System.Drawing.Point(703, 9);
            this.txtSearchMembers.Name = "txtSearchMembers";
            this.txtSearchMembers.Size = new System.Drawing.Size(140, 26);
            this.txtSearchMembers.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Manager";
            this.MainTabControl.ResumeLayout(false);
            this.tPgBooks.ResumeLayout(false);
            this.pnlMenuBooks.ResumeLayout(false);
            this.pnlMenuBooks.PerformLayout();
            this.pnlInfoBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBBook)).EndInit();
            this.pnlMainBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.tPgBooked.ResumeLayout(false);
            this.pnlMainBooked.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooked)).EndInit();
            this.pnlMenuBooked.ResumeLayout(false);
            this.pnlMenuBooked.PerformLayout();
            this.pnlInfoBooked.ResumeLayout(false);
            this.tPgMembers.ResumeLayout(false);
            this.pnlMainMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.pnlInfoMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBMemberPhoto)).EndInit();
            this.pnlMenuMembers.ResumeLayout(false);
            this.pnlMenuMembers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tPgBooked;
        private System.Windows.Forms.TabPage tPgMembers;
        private System.Windows.Forms.TabPage tPgBooks;
        private System.Windows.Forms.Panel pnlMenuBooks;
        private System.Windows.Forms.ComboBox cmbFilterBooks;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.TextBox txtSearchBooks;
        private System.Windows.Forms.Panel pnlInfoBooks;
        private System.Windows.Forms.Panel pnlMainBooks;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Panel pnlMainMembers;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.Panel pnlInfoMembers;
        private System.Windows.Forms.Panel pnlMenuMembers;
        private System.Windows.Forms.ComboBox cmbFilterMembers;
        private System.Windows.Forms.Button btnSearchMembers;
        private System.Windows.Forms.TextBox txtSearchMembers;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.PictureBox pcBMemberPhoto;
        private System.Windows.Forms.ListBox lstBMemberAllInfo;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.ListBox lstBBookAllInfo;
        private System.Windows.Forms.PictureBox pcBBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearPublished;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfMembership;
        private System.Windows.Forms.Panel pnlMainBooked;
        private System.Windows.Forms.DataGridView dataGridViewBooked;
        private System.Windows.Forms.Panel pnlMenuBooked;
        private System.Windows.Forms.Button btnCancelBooked;
        private System.Windows.Forms.Button btnAddBooked;
        private System.Windows.Forms.ComboBox cmbFilterBooked;
        private System.Windows.Forms.Button btnSerchBooked;
        private System.Windows.Forms.TextBox txtSearchBooked;
        private System.Windows.Forms.Panel pnlInfoBooked;
        private System.Windows.Forms.ListBox lstBBookedAllInfo;
        private System.Windows.Forms.Button btnSetFineBooked;
    }
}