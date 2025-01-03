using LowFatDependencyInjection.Models;
using LowFatDependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace LowFatDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        [HttpGet]
        [Route("{userId}")]
        public IActionResult Get(int userId)
        {
            var shoppingCart = _shoppingCartService.GetShoppingCart(userId);
            if (shoppingCart == null)
            {
                return NotFound();
            }
            return Ok(shoppingCart);
        }

        [HttpPost]
        [Route("{userId}")]
        public IActionResult Post(int userId, List<Product> products)
        {
            _shoppingCartService.UpsertShoppingCart(userId, products);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + userId, products);
        }

        [HttpDelete]
        [Route("{userId}")]
        public IActionResult Delete(int userId)
        {
            _shoppingCartService.DeleteShoppingCart(userId);
            return NoContent();
        }
    }
}
