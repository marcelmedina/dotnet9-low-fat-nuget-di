using LowFatDependencyInjection.Models;
using LowFatDependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace LowFatDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetProducts());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productService.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            _productService.CreateProduct(product);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + product.Id, product);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Product product)
        {
            if (_productService.GetProduct(id) == null)
            {
                return NotFound();
            }
            _productService.UpdateProduct(product);
            return Ok(product);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            if (_productService.GetProduct(id) == null)
            {
                return NotFound();
            }
            _productService.DeleteProduct(id);
            return NoContent();
        }
    }
}
