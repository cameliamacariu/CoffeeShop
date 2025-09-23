using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController(CoffeeDbContext coffeeDbContext) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var result = coffeeDbContext.Set<Coffee>().ToList();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Insert(int id)
        {
            var coffee = new Coffee()
            {
                Id = id,
                Name = "Capuccino " + id,
            };

            coffeeDbContext.Set<Coffee>().Add(coffee);

            return Ok(coffee);
        }
    }
}
