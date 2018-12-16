using System;
using AspNetCoreIntroduction.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntroduction.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DefaultRandomService _randomService;

        public ValuesController(DefaultRandomService randomService)
        {
            this._randomService = randomService ?? throw new ArgumentNullException(nameof(randomService));
        }
       

        [HttpGet("random")]
        public ActionResult<int> Random()
        {
            var result = this._randomService.GetValue();

            return result;
        }
    }
}
