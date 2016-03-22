using System;
using System.Windows.Forms;
using LibraryManager.Entities;
using LibraryManager.Repositories;
using System.Configuration;
using LibraryManager.Code;

namespace LibraryManager
{
    public partial class LoginForm : Form
    {
        private readonly IUserRepository _userRepository;

        public LoginForm()
        {
            _userRepository = new SqlUserRepository(ConfigurationManager.ConnectionStrings["dbLibrary"].ConnectionString);
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {             
            string login = txbLogin.Text;
            string password = Encryptor.MD5Hash(txbPassword.Text);

            User user = _userRepository.GetUserByLogin(login, password);

            if(user == null)
            {
                MessageBox.Show(this, "Invalid user name or password", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {                
                CurrentUser.Initialize(user);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
