using System;
using System.Windows.Forms;
using LibraryManager.Repositories;
using LibraryManager.Entities;
using System.Configuration;
using System.Drawing;

namespace LibraryManager
{
    public partial class AddMemberForm : Form
    {
        public readonly IMemberRepository _memberRepository;

        public AddMemberForm()
        {
            _memberRepository = new SqlMemberRepository(ConfigurationManager.ConnectionStrings["dbLibrary"].ConnectionString);

            InitializeComponent();

            txtDateMember.Text = monthCalendarMember.SelectionStart.ToString();
        }

        private void btnBrowsePhotoMember_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp";
            file.FilterIndex = 2;
            if(file.ShowDialog() == DialogResult.OK)
            {
                pcBPhotoMember.Image = Image.FromFile(file.FileName);
            }
        }

        private void btnCancelMember_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if(txtPassportMember.Text == "" || pcBPhotoMember.Image == null || txtNameMember.Text == "" || txtSurnameMember.Text == "" || txtDateMember.Text == "")
            {
                MessageBox.Show("One of * fields or image are empty");
            }
            else
            {
                Member member = new Member();
                member.FirstName = txtNameMember.Text;
                member.SecondName = txtSurnameMember.Text;
                member.PassportId = txtPassportMember.Text;                
                member.DateOfMembership = txtDateMember.Text;
                member.Address = txtAddressMember.Text;
                member.Phone = txtPhoneMember.Text;
                member.Email = txtEmailMember.Text;
                member.Photo = ImageManager.ImageToByteArray(pcBPhotoMember.Image);

                _memberRepository.AddMember(member);                

                this.Close();
            }
        }

        private void monthCalendarMember_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDateMember.Text = monthCalendarMember.SelectionStart.ToString();
        }
    }
}
