using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TestProject.API.Models.V2;

namespace TestProject.API.Controllers.V2
{
    // [Route("api/v{version:apiVersion}/[controller]")] //Preffered way
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
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
            return new List<Product>
            {
                new Product{Id=1, Name="Laptop", Price=85000},
                new Product{Id=2, Name="Desktop", Price=7000},
                new Product{Id=3, Name="Tablet", Price=25000},
            };
        }
    }
}
