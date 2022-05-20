using ProductManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Repository
{
    public class ProductListRepository:IProductRepository
    {
        List<Product> _productList;

        public ProductListRepository()
        {
            _productList = new List<Product>
            {
                new Product { Id = 1, Name = "Soap", Description = "Wash",Amount=100 },
                new Product { Id = 2, Name = "VimBar", Description = "Rinse",Amount=200 }

            };
        }
        public List<Product> GetProduct()
        {
            return _productList;
        }
        public void AddProduct(Product product)
        {
            product.Id = _productList.Count > 0 ? _productList.Max(x => x.Id) + 1 : 1;
            _productList.Add(product);
        }

        public Product GetProductById(int id)
        {
            Product product = _productList.Find(e => e.Id == id);
            return product;
        }

        public void EditProduct(Product product)
        {
            Product productToBeEdited = _productList.Find(x => x.Id == product.Id);
            productToBeEdited.Name = product.Name;
            productToBeEdited.Description = product.Description;
            productToBeEdited.Amount = product.Amount;
        }

        public void DeleteProduct(int id)
        {
            Product product = GetProductById(id);
            _productList.Remove(product);
        }

        public List<Product> GetProductByAmount(double amount)
        {
            List<Product> productamount = new List<Product>();
            foreach(Product product in _productList)
            {
                if(product.Amount > amount)
                {
                    productamount.Add(product);
                }
            }
            return productamount;
        }
    }
}
