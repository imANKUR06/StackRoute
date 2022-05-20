using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Model;
using ProductManagement.Repository;
using ProductManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductRepository _productRepository;
        public ProductController(IProductRepository iproductRepository)
        {
            _productRepository = iproductRepository;

        }
        [Authorize]
        [HttpGet]
        [Route("/api/Product")]
        public IActionResult ListProduct()
        {
            var product = _productRepository.GetProduct();
            return Ok(product);
        }

        [HttpGet]
        [Route("/api/Product/{id}")]
        public IActionResult GetProductId(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound($"This {id} is not Present");
            }
            return Ok(product);
        }

        [HttpPost]
        [Route("/api/Product/CreateProduct")]
        public IActionResult CreateProduct([FromBody] CreateProductViewModel createProductViewModel)
        {
            Product product = new Product { Name = createProductViewModel.Name, Description = createProductViewModel.Description, Amount = createProductViewModel.Amount };
            _productRepository.AddProduct(product);
            return CreatedAtAction("GetProductId", new { id = product.Id }, product);
        }
        [HttpPut]
        [Route("/api/Product/{id}")]
        public IActionResult UpdateProduct(EditProductViewModel editProductViewModel, int id)
        {
            Product product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound($"Product with {id} Not found");
            }
            product.Name = editProductViewModel.Name;
            product.Description = editProductViewModel.Description;
            product.Amount = editProductViewModel.Amount;
            _productRepository.EditProduct(product);
            return Ok(product);
        }

        [HttpDelete]
        [Route("/api/product/{id}")]

        public IActionResult RemoveProduct(int id)
        {
            Product product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound($"Product with {id} Not found");
            }
            _productRepository.DeleteProduct(id);
            return Ok($"Product with {id} was deleted");
        }

        [HttpGet]
        [Route("/api/product/Amount/{amount}")]
        public IActionResult GetProductByAmount(double amount)
        {
            var product = _productRepository.GetProductByAmount(amount);
            if (product.Count() == 0)
            {
                return NotFound($"No product has greater amount than {amount}");
            }
            
            return Ok(product);
        }
    }
}
