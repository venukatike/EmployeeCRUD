using Microsoft.AspNetCore.Mvc;
using RPOST.EmployeeApi.Application.Interfaces;
using RPOST.EmployeeApi.Domain.Entities;

namespace EmployeeCRUD.Controllers
{
    [ApiController]
    [Route("api")]
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet("Get")]
        public async Task<List<Product>> Gell()
        {
           var p= await productService.GetAll();
            return p;
        }

        [HttpPost("Post")]
        public async Task<IActionResult> AddProduct(Product product)
        {
            await productService.AddProduct(product);

            return Ok("Added Product!");

        }
    }
}
