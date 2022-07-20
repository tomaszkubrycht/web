using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace test4.Controllers
{
    [Authorize]
    public class MapsController : Controller
    {
        public IActionResult Index()
        {
            
            // And fake a login to create an authentication cookie
 
            return View();
        }
    }
}