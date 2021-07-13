using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoffeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeController : ControllerBase
    {
        public static readonly string[] Cofees = new[] {
            "flat white", "long black", "latte", "Americano", "cappuccino"
        };

        [HttpGet]
        public ActionResult Get(){
            var rng = new Random();
            return Ok(Cofees[rng.Next(Cofees.Length)]);
        }

    }
}