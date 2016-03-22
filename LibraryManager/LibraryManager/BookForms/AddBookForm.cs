using System;
using System.Windows.Forms;
using LibraryManager.Repositories;
using LibraryManager.Entities;
using System.Configuration;
using System.Drawing;

namespace LibraryManager
{
    public partial class AddBookForm : Form
    {
        public readonly IBookRepository _bookRepository;

        public AddBookForm()
        {
            _bookRepository = new SqlBookRepository(ConfigurationManager.ConnectionStrings["dbLibrary"].ConnectionString);

            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if(txtNameBook.Text == "" || txtAmountBook.Text == "" || txtAuthorBook.Text == "")
            {
                MessageBox.Show("One of * fields are empty");
            }

            else
            {
                Book book = new Book();
                book.Name = txtNameBook.Text;
                book.Author = txtAuthorBook.Text;
                book.Genre = txtGenreBook.Text;               
                book.Publisher = txtPublisherBook.Text;
                if (pcBPhotoBook.Image != null)
                {
                    book.Photo = ImageManager.ImageToByteArray(pcBPhotoBook.Image);
                }
                book.YearPublished = (txtYearBook.Text == "") ? 0 : Convert.ToInt32(txtYearBook.Text);
                book.Status = 1;


                _bookRepository.AddBook(book, Convert.ToInt32(txtAmountBook.Text));                
                
                this.Close();
            }            
        }

        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowsePhotoBook_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp";
            file.FilterIndex = 2;
            if (file.ShowDialog() == DialogResult.OK)
            {
                pcBPhotoBook.Image = Image.FromFile(file.FileName);
            }
        }
    }
}
