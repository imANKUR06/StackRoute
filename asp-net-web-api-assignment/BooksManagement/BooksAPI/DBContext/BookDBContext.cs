using BooksAPI.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAPI.DBContext
{
    public class BookDBContext:IdentityDbContext
    {

        public BookDBContext(DbContextOptions<BookDBContext> options) : base(options)
        {

        }
        public DbSet<Book> Book { get; set; }
    }
}
