using System;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntroduction.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("random")]
        public ActionResult<int> Random()
        {
            var random = new Random();

            var result = random.Next();

            return result;
        }
    }
}
