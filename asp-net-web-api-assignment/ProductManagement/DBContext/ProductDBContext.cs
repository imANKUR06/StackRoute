using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.DBContext
{
    public class ProductDBContext : IdentityDbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {

        }
        public DbSet<Product> Product { get; set; }
    }
}
