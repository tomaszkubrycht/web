using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using test4.Models;
using test4.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test4.Controllers
{
    [Authorize]
    public class PlotsController : Controller
    {
        private readonly PressureService _plotSub;
     

        public PlotsController(PressureService pressureService)
        {
            _plotSub = pressureService;
        }

        [AllowAnonymous]
        
        public ActionResult<IList<Submission>> Index() => View(_plotSub.Read());


        [AllowAnonymous]
        [HttpPost]
        public ActionResult list()
        {
            
            var tom = _plotSub.Read();
            return new JsonResult(tom);
        }

    }
}

