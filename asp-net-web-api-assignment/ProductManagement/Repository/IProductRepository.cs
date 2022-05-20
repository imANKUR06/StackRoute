using ProductManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProduct();
        void AddProduct(Product employee);
        Product GetProductById(int id);

        void EditProduct(Product employee);
        void DeleteProduct(int id);
        List<Product> GetProductByAmount(double Amount);
    }
}
