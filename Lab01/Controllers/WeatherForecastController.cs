using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab01.Class;

namespace Lab01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Soda> Get()
        {
            return ;
        }

        [HttpPost]
        public void Post([FromBody]Soda newSoda)
        {
            
        }

    }
}
