using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IntArrayManipulation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrayCalcController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Reverse()
        {
            return new string[] { "value1", "value2" };
        }


    }
}
