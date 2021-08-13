using System;
using System.Collections.Immutable;
using BlazorContractFormsPoc.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlazorContractFormsPoc.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OfficeController : ControllerBase
    {
        private static Office _data = new()
        {
            DateTime = DateTime.Now,
            Enabled = true,
            Int = 42,
            OfficeType = OfficeType.Fun,
            String = "",
            Staff = ImmutableList.Create(new Person[]{
                new()
                {
                    Name = ""
                },
                new()
                {
                    Name = "Roy"
                },
                new()
                {
                    Name = "John"
                }
            })
        };

        private readonly ILogger<OfficeController> _logger;

        public OfficeController(ILogger<OfficeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Office Get()
        {
            return _data;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Office office)
        {
            _data = office;
            return Ok();
        }

        public ActionResult<Office> Delete()
        {
            _data = new Office();
            return new ObjectResult(_data);
        }
    }
}
