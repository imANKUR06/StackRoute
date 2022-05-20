using BooksAPI.DBContext;
using BooksAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAPI.Repository
{
    public class sqlRepository:IBookRepository
    {
        BookDBContext _bookDBContext;
        public sqlRepository(BookDBContext bookDBContext)
        {
            _bookDBContext = bookDBContext;
        }
        public void AddBook(Book book)
        {
            _bookDBContext.Book.Add(book);
            _bookDBContext.SaveChanges();
        }

        public void DeleteBook(int id)
        {

            _bookDBContext.Book.Remove(GetBookById(id));
            _bookDBContext.SaveChanges();

        }

        public void EditBook(Book book)
        {
            var BookChanges = _bookDBContext.Book.Attach(book);
            BookChanges.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _bookDBContext.SaveChanges();
        }


        public List<Book> GetBook()
        {
            return _bookDBContext.Book.ToList();
        }

        public Book GetBookById(int id)
        {
            return _bookDBContext.Book.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBookByName(string name)
        {
            var book = _bookDBContext.Book.Where(x => x.Name.StartsWith(name));
            return book;
        }
        public void DeleteAllBooks()
        {
            foreach (Book book in _bookDBContext.Book.ToList())
            {
                _bookDBContext.Book.Remove(book);
            }
            _bookDBContext.SaveChanges();
        }
        public IEnumerable<Book> ShowBookBetween()
        {
            var book = _bookDBContext.Book.ToList();
            var maximum = GetGreatestBookByAmount() ;

            var minimum = book.Min(a => a.Amount);
            
            book.Remove(maximum);
            book.Remove(book.Find(x=>x.Amount == minimum));
            
            return book;
        }
        public Book GetGreatestBookByAmount()
        {
            
            List<Book> Bookamount = new List<Book>();
            Book temp = new Book();
            temp.Amount = int.MinValue;
            foreach (Book book in _bookDBContext.Book.ToList())
            {
                
                if (book.Amount > temp.Amount)
                {
                    temp.Id = book.Id;
                    temp.Amount = book.Amount;
                    temp.Name = book.Name;
                    temp.Description = book.Description;
                    temp.Author = book.Author;
                }
            }
            var result = _bookDBContext.Book.FirstOrDefault(x => x.Amount == temp.Amount);
            return result;
        }


        public List<Book> GetCheapestCostliestBookByAmount()
        {

            List<Book> Bookamount = new List<Book>();
            Book cheapest = new Book();
            cheapest.Amount = int.MaxValue;
            Book costliest = new Book();
            costliest.Amount = int.MinValue;
            foreach (Book cheapbook in _bookDBContext.Book.ToList())
            {

                if (cheapbook.Amount < cheapest.Amount)
                {
                    cheapest.Id = cheapbook.Id;
                    cheapest.Amount = cheapbook.Amount;
                    cheapest.Name = cheapbook.Name;
                    cheapest.Description = cheapbook.Description;
                    cheapest.Author = cheapbook.Author;
                }
            }
            Bookamount.Add(cheapest);
            foreach (Book costlybook in _bookDBContext.Book.ToList())
            {

                if (costlybook.Amount > costliest.Amount)
                {
                    costliest.Id = costlybook.Id;
                    costliest.Amount = costlybook.Amount;
                    costliest.Name = costlybook.Name;
                    costliest.Description = costlybook.Description;
                    costliest.Author = costlybook.Author;
                }
            }
            Bookamount.Add(costliest);

            return Bookamount;
        }



    }
}
