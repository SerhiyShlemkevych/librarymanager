using LibraryManager.Entities;
using System.Collections.Generic;

namespace LibraryManager.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> SelectBooks(string filterName, string filterValue);
        IEnumerable<BookInfo> SelectBooksInfo(string filterName, string filterValue);
        void AddBook(Book bookToAdd, int amountToAdd);
        void EditBook(Book bookToEdit);
        Book GetBookByNameAndAuthor(string name, string author);
        BookId GetBookIdByNameAndAuthor(string name, string author);
    }
}
