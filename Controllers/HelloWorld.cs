using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    [Route("[controller]")]
    public class HelloWorld : Controller
    {

        
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("[action]")]
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }




    }
}