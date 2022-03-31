using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TestProject.API.Models.V1;

namespace TestProject.API.Controllers.V1
{
   // [Route("api/v{version:apiVersion}/[controller]")]
   [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(GetProducts().ToList());
        }

        [NonAction]
        public IList<Product> GetProducts()
        {
            return new List<Product>{
                new Product{Id=1, Name="Laptop"},
                new Product{Id=2, Name="Desktop"},
                new Product{Id=3, Name="Tablet"},
            };
        }
    }
}
