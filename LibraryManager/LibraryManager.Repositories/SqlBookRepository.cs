using System;
using System.Collections.Generic;
using LibraryManager.Entities;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace LibraryManager.Repositories
{
    public class SqlBookRepository : IBookRepository
    {
        private readonly string _connectionString;

        public SqlBookRepository(string connectionString)
        {            
            _connectionString = connectionString;
        }

        public IEnumerable<Book> SelectBooks(string filterName, string filterValue)
        {
            string booksQuery;
            if (filterName == "")
            {
                booksQuery = "SELECT [Name], [Author], [Genre], [YearPublished], [Publisher], [PhotoId], [StatusId], [PhotoId] FROM [dbo].[tblBook] WHERE [StatusId] = 1";
            }
            else
            {
                booksQuery = String.Format("SELECT [Name], [Author], [Genre], [YearPublished], [Publisher], [PhotoId], [StatusId] FROM [dbo].[tblBook] WHERE [{0}] LIKE '%{1}%' AND [StatusId] = 1", filterName, filterValue);
            }           

            List<Book> booksList = new List<Book>();
            Book book;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = booksQuery;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            book = new Book();
                            book.Name = (string)reader["Name"];
                            book.Author = (string)reader["Author"];
                            book.Genre = (string)reader["Genre"];
                            book.YearPublished = (int)reader["YearPublished"];
                            book.Publisher = (string)reader["Publisher"];
                            if (reader["PhotoId"] != DBNull.Value)
                            {                                
                                book.Photo = (byte[])reader["PhotoId"];
                            }
                            book.Status = (int)reader["StatusId"];
                            booksList.Add(book);
                        }
                    }
                }
                                
                return booksList;
            }
        }
        public IEnumerable<BookInfo> SelectBooksInfo(string filterName, string filterValue)
        {
            string booksQuery;
            if (filterName == "")
            {
                booksQuery = "SELECT DISTINCT([Name]), [Author], [Genre], [YearPublished], [Publisher] FROM [dbo].[tblBook] WHERE [StatusId] = 1";
            }
            else
            {
                booksQuery = String.Format("SELECT [Name], [Author], [Genre], [YearPublished], [Publisher], [PhotoId], [StatusId] FROM [dbo].[tblBook] WHERE [{0}] LIKE '%{1}%' AND [StatusId] = 1", filterName, filterValue);
            }

            List<BookInfo> booksList = new List<BookInfo>();
            BookInfo book;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = booksQuery;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            book = new BookInfo();
                            book.Name = (string)reader["Name"];
                            book.Author = (string)reader["Author"];
                            book.Genre = (string)reader["Genre"];
                            book.YearPublished = (int)reader["YearPublished"];
                            book.Publisher = (string)reader["Publisher"];
                            booksList.Add(book);
                        }
                    }
                }

                return booksList;
            }
        }
        public Book GetBookByNameAndAuthor(string name, string author)
        {
            
            if (name == "" || author == "")
            {
                throw new Exception("No information about name or book author");
            }
            else
            {                 
                string booksQuery = String.Format("SELECT [Name], [Author], [Genre], [YearPublished], [Publisher], [PhotoId], [StatusId] FROM [dbo].[tblBook] WHERE [Name] = '{0}' AND [Author] = '{1}' AND [StatusId] = 1", name, author);

                Book book = new Book();

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = booksQuery;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {                                
                                book.Name = (string)reader["Name"];
                                book.Author = (string)reader["Author"];
                                book.Genre = (string)reader["Genre"];
                                book.YearPublished = (int)reader["YearPublished"];
                                book.Publisher = (string)reader["Publisher"];                                
                                book.Status = (int)reader["StatusId"];                                
                                if (reader["PhotoId"] != DBNull.Value)
                                {
                                    book.Photo = (byte[])reader["PhotoId"];
                                }
                            }
                        }
                    }

                    return book;
                }
            }
        }
        public BookId GetBookIdByNameAndAuthor(string name, string author)
        {

            if (name == "" || author == "")
            {
                throw new Exception("No information about name or book author");
            }
            else
            {
                string booksQuery = String.Format("SELECT TOP 1 [Id] FROM [dbo].[tblBook] WHERE [Name] = '{0}' AND [Author] = '{1}' AND [StatusId] = 1", name, author);

                BookId book = new BookId();

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = booksQuery;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                book.Id = (int)reader["Id"];                                
                            }
                        }
                    }

                    return book;
                }
            }
        }
        public void AddBook(Book bookToAdd, int amountToAdd)
        {
            if(bookToAdd == null)
            {
                throw new Exception("No book to add");
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string bookQuery;

                    if (bookToAdd.Photo == null)
                    {
                        bookQuery = "INSERT INTO [dbo].[tblBook] ([Name], [Author], [Genre], [YearPublished], [Publisher], [StatusId]) VALUES(@Name, @Author, @Genre, @YearPublished, @Publisher, @StatusId)";
                    }
                    else
                    {
                        bookQuery = "INSERT INTO [dbo].[tblBook] ([Name], [Author], [Genre], [YearPublished], [Publisher], [PhotoId], [StatusId]) VALUES(@Name, @Author, @Genre, @YearPublished, @Publisher, @Photo, @StatusId)";
                        command.Parameters.AddWithValue("@Photo", bookToAdd.Photo);
                    }

                    command.Connection = connection;                    
                    command.CommandText = bookQuery;
                                        
                    command.Parameters.AddWithValue("@Name", bookToAdd.Name);
                    command.Parameters.AddWithValue("@Author", bookToAdd.Author);
                    command.Parameters.AddWithValue("@Genre", bookToAdd.Genre);                    
                    command.Parameters.AddWithValue("@YearPublished", bookToAdd.YearPublished);
                    command.Parameters.AddWithValue("@Publisher", bookToAdd.Publisher);                    
                    command.Parameters.AddWithValue("@StatusId", 1); // 1 means book is present in library, 0 means book is not in library                    

                    for (int i = 0; i < amountToAdd; i++)
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        public void EditBook(Book bookToEdit)
        {
            string bookQuery;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    if (bookToEdit.Photo == null)
                    {
                        bookQuery = "UPDATE [dbo].[tblBook] SET [Name] = @Name, [Author] = @Author, [Genre] = @Genre, [YearPublished] = @YearPublished, [Publisher] = @Publisher, [StatusId] = @StatusId WHERE [Name] = @Name AND[Author] = @Author";
                    }
                    else
                    {
                        bookQuery = "UPDATE [dbo].[tblBook] SET [Name] = @Name, [Author] = @Author, [Genre] = @Genre, [YearPublished] = @YearPublished, [Publisher] = @Publisher, [PhotoId] = @PhotoId, [StatusId] = @StatusId WHERE [Name] = @Name AND[Author] = @Author";
                        command.Parameters.AddWithValue("@PhotoId", bookToEdit.Photo);
                    }
                       
                    command.Connection = connection;
                    command.CommandText = bookQuery;

                    command.Parameters.AddWithValue("@Name", bookToEdit.Name);
                    command.Parameters.AddWithValue("@Author", bookToEdit.Author);
                    command.Parameters.AddWithValue("@Genre", bookToEdit.Genre);
                    command.Parameters.AddWithValue("@YearPublished", bookToEdit.YearPublished);
                    command.Parameters.AddWithValue("@Publisher", bookToEdit.Publisher);                    
                    command.Parameters.AddWithValue("@StatusId", bookToEdit.Status); // 1 means book is present in library, 0 means book is not in library

                    command.ExecuteNonQuery();
                }
            }
        }        
    }
}
