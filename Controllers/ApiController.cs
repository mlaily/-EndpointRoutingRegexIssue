using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        // without the catch-all (only "comments/{url}"), the route works as expected
        [Route("comments/{*url}")]
        public async Task<IActionResult> TestAsync(string url)
        {
            return Content("ApiController");
        }
    }
}