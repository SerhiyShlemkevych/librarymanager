using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        //no exception handling

        //when create or edit book to see result program restart required

        //not fully proper validation of user input

        //i would advise u to create label for image when image is required

        //when search i can enter anything in combobox with column names -> exception
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm frmLogin = new LoginForm();            
            if(frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }

            
        }
    }
}
