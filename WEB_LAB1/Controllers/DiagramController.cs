using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_LAB1.Models;

namespace WEB_LAB1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiagramController : ControllerBase
    {
        private readonly ProductsContext _context;
        public DiagramController(ProductsContext context)
        {
            _context = context;
        }

        [HttpGet("JsonData")]

        public JsonResult JsonData()
        {
            var products = _context.Products.ToList();
            List<Object> result = new List<Object>();
            result.Add(new[] { "Products", "Count" });
            foreach (var product in products)
            {
                result.Add(new object[] {product.ProductName, product.Price});
            }
            return new JsonResult(result);
        }

    }
}
