using BooksAPI.Model;
using BooksAPI.Repository;
using BooksAPI.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BookController : ControllerBase
    {
        IBookRepository _bookRepository;

        public BookController(IBookRepository ibookRepository)
        {
            _bookRepository = ibookRepository;
        }
  

        [HttpGet]
        [Route("/api/Book")]
        public IActionResult ListBook()
        {
            var book = _bookRepository.GetBook();
            return Ok(book);
        }

        [HttpGet]
        [Route("/api/Book/{id}")]
        public IActionResult GetBookId(int id)
        {
            var book = _bookRepository.GetBookById(id);
            if (book == null)
            {
                return NotFound($"This {id} is not Present");
            }
            return Ok(book);
        }
        //[Authorize]
        [HttpPost]
        [Route("/api/Book/CreateBook")]
        public IActionResult CreateBook([FromBody] CreateBookViewModel createBookViewModel)
        {
            Book book = new Book { Name = createBookViewModel.Name, Description = createBookViewModel.Description, Amount = createBookViewModel.Amount, Author = createBookViewModel.Author };
            _bookRepository.AddBook(book);
            return CreatedAtAction("GetBookId", new { id = book.Id }, book);
        }

        //[Authorize]
        [HttpPut]
        [Route("/api/Book/{id}")]
        public IActionResult UpdateBook(EditBookViewModel editBookViewModel, int id)
        {
            Book book = _bookRepository.GetBookById(id);
            if (book == null)
            {
                return NotFound($"Book with {id} Not found");
            }
            book.Name = editBookViewModel.Name;
            book.Description = editBookViewModel.Description;
            book.Amount = editBookViewModel.Amount;
            book.Author = editBookViewModel.Author;
            _bookRepository.EditBook(book);
            return Ok(book);
        }

        //[Authorize]
        [HttpDelete]
        [Route("/api/Book/{id}")]

        public IActionResult RemoveBook(int id)
        {
            Book book = _bookRepository.GetBookById(id);
            if (book == null)
            {
                return NotFound($"Book with {id} Not found");
            }
            _bookRepository.DeleteBook(id);
            return Ok($"Book with {id} was deleted");
        }

        [HttpGet]
        [Route("/api/Book/Amount")]
        public IActionResult GetBookByAmount()
        {
            var book = _bookRepository.GetGreatestBookByAmount();
            if (book == null)
            {
                return NotFound($"No Book is in DataBase ");
            }

            return Ok(book);
        }

        [HttpGet]
        [Route("/api/Book/CheapCostly")]
        public IActionResult GetCheapandCostlyBookByAmount()
        {
            List<Book> book = _bookRepository.GetCheapestCostliestBookByAmount();
            if (book == null)
            {
                return NotFound($"No Book is in DataBase ");
            }

            return Ok(book);
        }

        [HttpGet]
        //getbookByname
        [Route("/api/Book/getbook/{name}")]
        public IActionResult GetBookbyNameWithA(string name)
        {
            IEnumerable<Book> book = _bookRepository.GetBookByName(name);
            if (book == null)
            {
                return NotFound($"No Books is in DataBase ");
            }

            return Ok(book);
        }


        //[Authorize]
        [HttpDelete]
        [Route("/api/Book/deleteAll")]
        public IActionResult DeleteAllBooks()
        {
            _bookRepository.DeleteAllBooks();
            return Ok();
        }

        [HttpGet]
        [Route("/api/Book/Between")]
        public IActionResult Between()
        {
            List<Book> book = _bookRepository.GetBook();
            if (book.Count() == 0)
            {
                return NotFound($"No Book is in DataBase ");
            }

            IEnumerable<Book> bookbetween =  _bookRepository.ShowBookBetween();
            
            return Ok(bookbetween);
        }
    }
}
