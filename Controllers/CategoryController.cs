using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Skate.Interfaces;
using Skate.Models;
using System.Collections.Generic;

namespace Skate.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        
        private readonly ICategoryRepository _repository;
        private readonly ILogger<CategoryController> _logger;
        public CategoryController(ILogger<CategoryController> logger, ICategoryRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet("create/{category}")]
        public IActionResult CreateCategory(Category category)
        {
            _repository.Create(category);
            return Ok();
        }

        [HttpGet("delete/{id}")]
        public IActionResult DeleteCategory(int id)
        {
            _repository.Delete(id);
            return Ok();
        }
        
        [HttpGet("get/{id}")]
        public Category GetCategory(int id)
        {
            return _repository.GetCategory(id);
        }

        [HttpGet("getAll")]
        public IEnumerable<Category> GetCategories()
        {
            return _repository.GetAllCategories();
        }
    }
}
