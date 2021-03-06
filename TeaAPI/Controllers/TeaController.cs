using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TeaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        public static readonly string[] Teas = new[] {
            "Green", "Peppermint", "Earl Gray", "English Breakfast", "Camomille"
        };

        [HttpGet]
        public ActionResult Get(){
            var rng = new Random();

            return Ok(Teas[rng.Next(Teas.Length)]);
        }

    }
}