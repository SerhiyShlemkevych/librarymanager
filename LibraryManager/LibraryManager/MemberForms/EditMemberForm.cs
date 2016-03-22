using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryManager.Repositories;
using LibraryManager.Entities;
using System.Configuration;
using System.IO;

namespace LibraryManager
{
    public partial class EditMemberForm : Form
    {
        private Member _memberToEdit;
        public readonly IMemberRepository _memberRepository;

        public EditMemberForm(Member memberToEdit)
        {
            _memberRepository = new SqlMemberRepository(ConfigurationManager.ConnectionStrings["dbLibrary"].ConnectionString);
            _memberToEdit = memberToEdit;
            InitializeComponent();

            if(_memberToEdit.Photo != null && _memberToEdit.Photo.Length > 0)
            {
                pcBPhotoMember.Image = ImageManager.ByteArrayToImage(_memberToEdit.Photo);
            }

            txtNameMember.Text = _memberToEdit.FirstName;
            txtSurnameMember.Text = _memberToEdit.SecondName;
            txtDateMember.Text = _memberToEdit.DateOfMembership;
            txtPassportMember.Text = _memberToEdit.PassportId;
            txtEmailMember.Text = _memberToEdit.Email;
            txtPhoneMember.Text = _memberToEdit.Phone;
            txtAddressMember.Text = _memberToEdit.Address;
            chkBDeletedMember.Checked = _memberToEdit.Deleted;
        }

        private void btnBrowsePhotoMember_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp";
            file.FilterIndex = 2;
            if (file.ShowDialog() == DialogResult.OK)
            {
                pcBPhotoMember.Image = Image.FromFile(file.FileName);
            }
        }

        private void btnCancelMember_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (txtPassportMember.Text == "" || pcBPhotoMember.Image == null || txtNameMember.Text == "" || txtSurnameMember.Text == "" || txtDateMember.Text == "")
            {
                MessageBox.Show("One of * fields or image are empty");
            }
            else
            {
                string passport = _memberToEdit.PassportId;
                _memberToEdit.FirstName = txtNameMember.Text;
                _memberToEdit.SecondName = txtSurnameMember.Text;
                _memberToEdit.PassportId = txtPassportMember.Text;
                _memberToEdit.DateOfMembership = txtDateMember.Text;
                _memberToEdit.Address = txtAddressMember.Text;
                _memberToEdit.Phone = txtPhoneMember.Text;
                _memberToEdit.Email = txtEmailMember.Text;
                _memberToEdit.Photo = ImageManager.ImageToByteArray(pcBPhotoMember.Image);
                _memberToEdit.Deleted = chkBDeletedMember.Checked;
                _memberRepository.EditMember(_memberToEdit, passport);                

                this.Close();
            }
        }

        private void monthCalendarMember_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDateMember.Text = monthCalendarMember.SelectionStart.ToString();
        }
    }
}
