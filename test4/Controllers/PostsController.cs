using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test4.Models;
using test4.Services;

namespace test4.Controllers
{

    

    [Route("api/[controller]")]
    [ApiController]
    public class PressureController : Controller
    {

        private readonly PressureService _pressSvc;

        public PressureController(PressureService pressuresService)
        {
            _pressSvc = pressuresService;
        }
        // GET: api/Posts
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Posts/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            
            return "value"+id.ToString();

        }

        // POST: api/Posts
        /// <summary>
        /// funkcja zapisujaca do bazy
        /// </summary>
        /// <param name="pressures"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<Pressures> Create(Pressures pressures)
        {

            pressures.observationDate = DateTime.Now;


            //if (ModelState.IsValid)
            //{
            //    _pressSvc.Create(pressures);
            //}
            return pressures;
        }

            // PUT: api/Posts/5
            [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
