using Microsoft.AspNetCore.Mvc;
using product_catalog.Models;
using product_catalog.Providers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace product_catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductProvider productProvider;

        public ProductsController(IProductProvider productProvider)
        {
            this.productProvider = productProvider;
        }
        [HttpGet]
        [Produces(typeof(IEnumerable<Product>))]
        public async Task<IActionResult> GetAllProducts() => Ok(await productProvider.GetProducts());

        [HttpGet]
        [Produces(typeof(Product))]
        [Route("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = (await productProvider.GetProducts()).Where(x => x.Id == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound($"Product {id} does not exists.");
            }
            return Ok(product);
        }

    }
}
