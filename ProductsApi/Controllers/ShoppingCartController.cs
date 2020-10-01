using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsApi.Data.Entities;
using ProductsApi.Services.DbService;


namespace ProductsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IDbService<Cart> _dbCartService;

        public ShoppingCartController(IDbService<Cart> dbCartService)
        {
            _dbCartService = dbCartService;
        }

        [HttpGet]
        public async Task<ActionResult<Cart>> GetAsync()
        {
            var sessionId = HttpContext.Session.Id;
            return await _dbCartService.Get(sessionId);
        }


        [Route("add")]
        [HttpPost]
        public async Task<Cart> Create(Cart cart)
        {
            var sessionId = HttpContext.Session.Id;
            cart.SessionId = sessionId;
            return await _dbCartService.AddOneAsync(cart);
        }

        [Route("Update")]
        [HttpPost]
        public async Task<Cart> Update(Cart cart)
        {
            var sessionId = HttpContext.Session.Id;
            cart.SessionId = sessionId;
            return await _dbCartService.Update(cart);
        }


    }
}
