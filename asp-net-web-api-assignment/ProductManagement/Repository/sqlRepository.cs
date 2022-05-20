using ProductManagement.DBContext;
using ProductManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Repository
{
    public class sqlRepository : IProductRepository
    {

        ProductDBContext _productDBContext;
        public sqlRepository(ProductDBContext productDBContext)
        {
            _productDBContext = productDBContext;
        }
        public void AddProduct(Product product)
        {
            _productDBContext.Product.Add(product);
            _productDBContext.SaveChanges();
        }

        public void DeleteProduct(int id)
        {

            _productDBContext.Product.Remove(GetProductById(id));
            _productDBContext.SaveChanges();
            
        }

        public void EditProduct(Product product)
        {
            var productChanges = _productDBContext.Product.Attach(product);
            productChanges.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            
            _productDBContext.SaveChanges();
        }


        public List<Product> GetProduct()
        {
            return _productDBContext.Product.ToList();
        }

        public Product GetProductById(int id)
        {
            return _productDBContext.Product.FirstOrDefault(x => x.Id == id);
        }

        public List<Product> GetProductByAmount(double Amount)
        {
            List<Product> productamount = new List<Product>();
            foreach (Product product in _productDBContext.Product.ToList())
            {
                if (product.Amount > Amount)
                {
                    productamount.Add(product);
                }
            }
            return productamount;
        }

        
    }

}
