using Erp.BL.DTOs.NewFolder;
using Erp.BL.Services.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Erp.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServies _productServies;

        public ProductController(IProductServies productServies)
        {
            _productServies = productServies;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _productServies.GetProducts();
            return Ok(products);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(Guid id)
        {
            var product = _productServies.GetProductById(id);
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProductDto product)
        {
            _productServies.CreateProduct(product);
            return Ok(product);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(Guid id, [FromBody] ProductDto product)
        {
            _productServies.UpdateProduct(id, product);
            return Ok(product);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(Guid id)
        {
            _productServies.DeleteProduct(id);
            return Ok();
        }
    }
}