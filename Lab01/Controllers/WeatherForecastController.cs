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
            return null; 
        }

        [HttpPost]
        public void Post([FromBody]Soda newSoda)
        {
            BTree<String,Soda> Tree5 = new BTree<String, Soda>(5); //instance class btree

            Tree5.Insert(newSoda.Name,newSoda); //method insert
            
        }

    }
}
