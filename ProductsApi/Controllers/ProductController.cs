using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsApi.Data.Entities;
using ProductsApi.Services.DbService;

namespace ProductsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IDbService<Product> _dbProductService;

        public ProductController(IDbService<Product> dbProductService)
        {
            _dbProductService = dbProductService;
        }

        [HttpGet]
        public async Task<ActionResult<Product[]>> GetAsync()
        {
            HttpContext.Session.SetString("123", "233");
            return await _dbProductService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetAsync(string id)
        {
             HttpContext.Session.SetString("123", "233");
            return await _dbProductService.Get(id);
        }
        
        [Route("add")]
        [HttpPost]
        public async Task<Product> Create(Product product) =>
            await _dbProductService.AddOneAsync(product);

    }
}
