using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryManager.Entities;
using LibraryManager.Repositories;
using System.Configuration;

namespace LibraryManager
{
    public partial class MainForm : Form
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMemberRepository _memberRepository;
        private readonly IBookedRepository _bookedRepository;
        private readonly IUserRepository _userRepository;

        public MainForm()
        {
            InitializeComponent();

            _bookRepository = new SqlBookRepository(ConfigurationManager.ConnectionStrings["dbLibrary"].ConnectionString);
            _memberRepository = new SqlMemberRepository(ConfigurationManager.ConnectionStrings["dbLibrary"].ConnectionString);
            _bookedRepository = new SqlBookedRepository(ConfigurationManager.ConnectionStrings["dbLibrary"].ConnectionString);
            _userRepository = new SqlUserRepository(ConfigurationManager.ConnectionStrings["dbLibrary"].ConnectionString);
            // Fill BookDataGrid with all books
            IEnumerable<BookInfo> bookList = _bookRepository.SelectBooksInfo("", "");
            dataGridViewBooks.ClearSelection();
            dataGridViewBooks.DataSource = bookList;

            // Fill MemberDataGrid with all members
            IEnumerable<MemberIdInfo> memberList = _memberRepository.SelectMembersIdInfo("", "");
            dataGridViewMembers.ClearSelection();
            dataGridViewMembers.DataSource = memberList;

            IEnumerable<BookedInfo> bookedList = _bookedRepository.SelectInfo(cmbFilterBooked.Text, txtSearchBooked.Text);
            dataGridViewBooked.ClearSelection();
            dataGridViewBooked.DataSource = bookedList;
        }

        #region BookTab

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            IEnumerable<BookInfo> bookList = _bookRepository.SelectBooksInfo(cmbFilterBooks.Text, txtSearchBooks.Text);
            dataGridViewBooks.ClearSelection();
            dataGridViewBooks.DataSource = bookList;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm frmAddBook = new AddBookForm();
            frmAddBook.Show();
        }

        private void dataGridViewBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRowCount = dataGridViewBooks.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                pcBBook.Image = null;
                lstBBookAllInfo.Items.Clear();

                string name = dataGridViewBooks.SelectedRows[0].Cells[0].Value.ToString();
                string author = dataGridViewBooks.SelectedRows[0].Cells[1].Value.ToString();
                Book book = _bookRepository.GetBookByNameAndAuthor(name, author);

                if (book.Photo != null && book.Photo.Length > 0)
                {
                    pcBBook.Image = ImageManager.ByteArrayToImage(book.Photo);
                }

                lstBBookAllInfo.Items.Add(String.Format("Name: {0}", book.Name));
                lstBBookAllInfo.Items.Add(String.Format("Author: {0}", book.Author));
                lstBBookAllInfo.Items.Add(String.Format("Genre: {0}", book.Genre));
                lstBBookAllInfo.Items.Add(String.Format("Year published: {0}", book.YearPublished));
                lstBBookAllInfo.Items.Add(String.Format("Publisher: {0}", book.Publisher));
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count == 1)
            {
                string name = dataGridViewBooks.SelectedRows[0].Cells[0].Value.ToString();
                string author = dataGridViewBooks.SelectedRows[0].Cells[1].Value.ToString();
                Book book = _bookRepository.GetBookByNameAndAuthor(name, author);
                EditBookForm frmEditBook = new EditBookForm(book);
                frmEditBook.Show();
            }
        }

        #endregion

        #region MemberTab

        private void btnSearchMembers_Click(object sender, EventArgs e)
        {
            IEnumerable<MemberIdInfo> memberList = _memberRepository.SelectMembersIdInfo(cmbFilterMembers.Text, txtSearchMembers.Text);
            dataGridViewMembers.ClearSelection();
            dataGridViewMembers.DataSource = memberList;
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            AddMemberForm frmAddMember = new AddMemberForm();
            frmAddMember.Show();
        }

        private void dataGridViewMembers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRowCount = dataGridViewMembers.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                pcBMemberPhoto.Image = null;

                string passport = dataGridViewMembers.SelectedRows[0].Cells[0].Value.ToString();
                Member member = _memberRepository.GetMemberByPassport(passport);                
                                
                if (member.Photo != null && member.Photo.Length > 0)
                {
                    pcBMemberPhoto.Image = ImageManager.ByteArrayToImage(member.Photo);
                }

                lstBMemberAllInfo.Items.Clear();
                lstBMemberAllInfo.Items.Add(String.Format("Name: {0}", member.FirstName));
                lstBMemberAllInfo.Items.Add(String.Format("Surname: {0}", member.SecondName));
                lstBMemberAllInfo.Items.Add(String.Format("Phone: {0}", member.Phone));
                lstBMemberAllInfo.Items.Add(String.Format("Email: {0}", member.Email));
                lstBMemberAllInfo.Items.Add(String.Format("Address: {0}", member.Address));
                lstBMemberAllInfo.Items.Add(String.Format("Deleted: {0}", member.Deleted ? "Deleted" : "Not deleted"));                
            }
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (dataGridViewMembers.SelectedRows.Count == 1)
            {
                string passport = dataGridViewMembers.SelectedRows[0].Cells[0].Value.ToString();
                Member member = _memberRepository.GetMemberByPassport(passport);
                EditMemberForm frmEditMember = new EditMemberForm(member);
                frmEditMember.Show();                
            }
        }

        #endregion

        #region BookedTab

        private void btnAddBooked_Click(object sender, EventArgs e)
        {
            AddBookedForm frmAddBooked = new AddBookedForm();
            frmAddBooked.Show();
        }

        private void dataGridViewBooked_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRowCount = dataGridViewBooked.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                int bookedId = Convert.ToInt32(dataGridViewBooked.SelectedRows[0].Cells[0].Value.ToString());
                Booked booked = _bookedRepository.GetBookedById(bookedId);
                User user = _userRepository.GetUserById(booked.UserId);

                lstBBookedAllInfo.Items.Clear();
                lstBBookedAllInfo.Items.Add(String.Format("Booked Id: {0}", booked.Id));
                lstBBookedAllInfo.Items.Add(String.Format("Member Id: {0}", booked.MemberId));
                lstBBookedAllInfo.Items.Add(String.Format("Book Id: {0}", booked.BookId));
                lstBBookedAllInfo.Items.Add(String.Format("Date Booked Id: {0}", booked.dateBooked));
                lstBBookedAllInfo.Items.Add(String.Format("Due Date: {0}", booked.dueBooked));
                lstBBookedAllInfo.Items.Add(String.Format("Fine: {0}", booked.fine));
                lstBBookedAllInfo.Items.Add(String.Format("Booked Status: {0}", booked.StatusId));
                lstBBookedAllInfo.Items.Add("Booked creator:");
                lstBBookedAllInfo.Items.Add(String.Format("Name: {0}", user.FirstName));
                lstBBookedAllInfo.Items.Add(String.Format("Surname: {0}", user.SecondName));
                lstBBookedAllInfo.Items.Add(String.Format("Id: {0}", user.Id));
                lstBBookedAllInfo.Items.Add(String.Format("Disabled: {0}", user.IsDisabled));
            }
        }

        private void btnSearchBooked_Click(object sender, EventArgs e)
        {            
            IEnumerable <BookedInfo> bookedList = _bookedRepository.SelectInfo(cmbFilterBooked.Text, txtSearchBooked.Text);
            dataGridViewBooked.ClearSelection();
            dataGridViewBooked.DataSource = bookedList;
        }


        private void btnCancelBooked_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                int selectedRowCount = dataGridViewBooked.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount == 1)
                {
                    int bookedId = Convert.ToInt32(dataGridViewBooked.SelectedRows[0].Cells[0].Value.ToString());
                    Booked booked = _bookedRepository.GetBookedById(bookedId);
                    _bookedRepository.DeleteBooked(booked);
                }
            }
        }

        private void btnSetFineBooked_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridViewBooked.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                int bookedId = Convert.ToInt32(dataGridViewBooked.SelectedRows[0].Cells[0].Value.ToString());
                Booked booked = _bookedRepository.GetBookedById(bookedId);                
                SetFineForm frmSetFine = new SetFineForm(booked);
                frmSetFine.Show();
            }            
        }

        #endregion
    }
}
