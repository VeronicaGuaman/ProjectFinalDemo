using Microsoft.AspNetCore.Mvc;
using ProjectFinalDemo.Application.Services.Interfaces;

namespace ProjectFinalDemo.API.Controllers
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
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAll();
            return Ok(products);
        }
    }
}
