using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class PostOrPageController : Controller
    {
        // Removing this first route fixes the problem with the api route not being found...
        [Route(@"{year:regex(^\d{{4}}$)}/{month:regex(^\d{{2}}$)}/{day:regex(^\d{{2}}$)}/{name}")]
        [Route(@"{name}")]
        public async Task<IActionResult> TestAsync(PostOrPageRouteData postOrPageRouteData)
        {
            return Content("PostOrPageController");
        }
    }

    public class PostOrPageRouteData
    {
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string Name { get; set; }
    }
    }