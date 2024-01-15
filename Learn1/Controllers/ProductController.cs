using Learn1.Application.DTOs;
using Learn1.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Learn1.Controllers
{
    [Route("product/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        

        /// <summary>
        /// Use this function to get all products
        /// </summary>
        /// <returns>ActionResult of List of ProductDto</returns>
        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> GetAll()
        {
            List<ProductDto> productDtos = await _productService.GetAllAsync();
            return Ok(productDtos);
        }
    }
}
