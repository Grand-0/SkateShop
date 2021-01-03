using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Skate.Interfaces;
using Skate.Models;
using System.Collections.Generic;

namespace Skate.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        private readonly IProductRepository _repository;

        public ProductController(ILogger<ProductController> logger, IProductRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet("get/{id}")]
        public Product GetProductById(int id)
        {
            return _repository.GetProduct(id);
        }

        [HttpGet("getAll")]
        public IEnumerable<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _repository.Delete(id);
            return Ok();
        }

        [HttpGet("create/{product}")]
        public IActionResult CreateProduct(Product product)
        {
            _repository.Create(product);
            return Ok();
        }

        [HttpGet("getByCategory/{categoryId}")]
        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return _repository.GetByPredicate(p => p.CategoryId == categoryId);
        }
    }
}
