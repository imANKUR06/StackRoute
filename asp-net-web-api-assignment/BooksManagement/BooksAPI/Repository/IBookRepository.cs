using BooksAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAPI.Repository
{
    public interface IBookRepository
    {
        List<Book> GetBook();
        void AddBook(Book book);
        Book GetBookById(int id);
        IEnumerable<Book> GetBookByName(string name);
        void EditBook(Book book);
        void DeleteAllBooks();
        IEnumerable<Book> ShowBookBetween();
        void DeleteBook(int id);
        Book GetGreatestBookByAmount();
        List<Book> GetCheapestCostliestBookByAmount();

    }
}
