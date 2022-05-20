using Microsoft.AspNetCore.Mvc;
using ProductManagement.Models;
using ProductManagement.Repository;
using ProductManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductList()
        {
            List<Product> products = _productRepository.GetProduct();
            return View(products);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductCreateViewModel productCreateViewModel)
        {
            if(ModelState.IsValid)
            {
                Product product = new Product { Name = productCreateViewModel.Name, Description = productCreateViewModel.Description,Amount = productCreateViewModel.Amount };
                _productRepository.AddProduct(product);
                return RedirectToAction("ProductList");
            }
            return View(productCreateViewModel);
        }
        [HttpGet]
        public IActionResult EditProduct(int Id)
        {
            Product product = _productRepository.GetProductById(Id);
            ProductEditViewModel productEditViewModel = new ProductEditViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Amount = product.Amount

            };
            return View(productEditViewModel);
        }

        [HttpPost]
        public IActionResult EditProduct(ProductEditViewModel productEditViewModel)
        {
            if (ModelState.IsValid)
            {
                Product product = _productRepository.GetProductById(productEditViewModel.Id);
                product.Name = productEditViewModel.Name;
                product.Description = productEditViewModel.Description;
                product.Amount = productEditViewModel.Amount;
                _productRepository.UpdateProduct(product);
                return RedirectToAction("ProductList");

            }

            return View(productEditViewModel);
        }
        [HttpGet]
        public IActionResult EraseProduct(int Id)
        {
            _productRepository.DeleteProduct(Id);
            return RedirectToAction("ProductList");
        }
        
    }
}
