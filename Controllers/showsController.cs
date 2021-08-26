using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phish_Website.Backend.Model;

namespace phish_website.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class showsController : ControllerBase
    {
        // GET: api/shows
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<Shows> Get()
        {
            Shows readShows = new Shows();
            List<Shows> showsList = readShows.ReadBehavior.ReadShowTable();
            showsList.Sort();
            return showsList;
        }

        // GET: api/shows/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/shows
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/shows/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/shows/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
