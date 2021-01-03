using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Skate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skate.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderRepository _repository;

        public OrderController(ILogger<OrderController> logger, IOrderRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet("make/{phone}/{address}")]
        public IActionResult MakeOrder(string phone, string address)
        {
            _repository.MakeOrder(phone, address);
            return Ok();
        }

        [HttpGet("addProduct/{id}")]
        public IActionResult AddProduct(int id)
        {
            _repository.AddProduct(id);
            return Ok();
        }
    }
}
