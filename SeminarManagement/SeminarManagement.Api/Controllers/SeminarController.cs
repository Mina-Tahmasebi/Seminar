using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarManagement.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeminarController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("This is a test");
        }
    }
}
