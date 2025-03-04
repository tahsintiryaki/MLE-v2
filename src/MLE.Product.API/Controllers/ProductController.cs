using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using MLE.Product.Application.Dtos;
using MLE.Product.Application.Interfaces.Services;

namespace MLE.Product.API.Controllers
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

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto request)
        {
            var response = await _productService.CreateProduct(request);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductList()
        {
            var response = await _productService.GetProducts();
            return Ok(response);
        }
    }
}