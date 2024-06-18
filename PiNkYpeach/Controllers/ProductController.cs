using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PiNkYpeach.Api.Extensions;
using PiNkYpeach.Api.Services.Interfaces;
using PiNkYpeach.Models.Dtos;

namespace PiNkYpeach.Api.Controllers
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
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {
            try
            {
                var products = await _productService.GetItems();
                var productCategories = await _productService.GetCategories();

                if (products == null || productCategories == null)
                {
                    return NotFound();
                }
                else
                {
                    var productDtos = products.ConvertToDto(productCategories);
                    return Ok(productDtos);

                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                                 "Error retrieving data from the database :(");
            }
        }
    }
}
