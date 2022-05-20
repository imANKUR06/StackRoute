using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProduct();
        void AddProduct(Product product);
        Product GetProductById(int id);

        void UpdateProduct(Product product);

        void DeleteProduct(int Id);


    }
}
