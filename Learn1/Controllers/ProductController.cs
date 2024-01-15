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

        [HttpGet("{productId}")]
        public async Task<ActionResult<ProductDto>> GetProductById(int productId)
        {
            if(productId <= 0) {
                return BadRequest();
            }

            ProductDto productDtos = await _productService.GetByIdAsync(productId);

            if(productDtos == null)
            {
                return NotFound();
            }
            return Ok(productDtos);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody] ProductPostDto productPostDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _productService.AddAsync(productPostDto);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteProductById(int productId)
        {
            if(productId <= 0) {
                return BadRequest();
            }
            await _productService.DeleteAsync(productId);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateProductById([FromBody] ProductDto productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _productService.UpdateAsync(productDto);
            return Ok();
        }
    }
}
