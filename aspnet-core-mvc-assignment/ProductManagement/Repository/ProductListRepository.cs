using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Repository
{
    public class ProductListRepository : IProductRepository
    {
        List<Product> _productslist;

        public ProductListRepository()
        {
            _productslist = new List<Product> {
                new Product { Id = 100, Name = "Soapify", Description = "Wash", Amount = 100 }
            };
        }
        public List<Product> GetProduct()
        {
            return _productslist;
        }
        public void AddProduct(Product product)
        {
            product.Id = _productslist.Count > 0 ? _productslist.Max(x => x.Id) + 1 : 100;
            _productslist.Add(product);
        }
        public Product GetProductById(int Id)
        {
            Product product = _productslist.Find(e => e.Id == Id);
            return product;
        }

        public void UpdateProduct(Product product)
        {
            Product productupdated = _productslist.Find(x => x.Id == product.Id);
            productupdated.Name = product.Name;
            productupdated.Description = product.Description;
            productupdated.Amount = product.Amount;

        }
        void IProductRepository.DeleteProduct(int Id)
        {
           Product product =  _productslist.Find(e => e.Id == Id);
            _productslist.Remove(product);
        }

        
    }
}
