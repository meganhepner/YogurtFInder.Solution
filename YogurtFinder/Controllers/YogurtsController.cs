using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YogurtFinder.Models;

namespace YogurtFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YogurtsController : ControllerBase
    {
      private YogurtFinderContext _db;
      public YogurtsController(YogurtFinderContext db)
      {
        _db = db;
      }
        // GET api/yogurts
        [HttpGet]
        public ActionResult<IEnumerable<Yogurt>> Get()
        {
            return _db.Yogurts.ToList();
        }

        // GET api/yogurts/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/yogurts
        [HttpPost]
        public void Post([FromBody] Yogurt yogurt)
        {
          _db.Yogurts.Add(yogurt);
          _db.SaveChanges();
        }

        // PUT api/yogurts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/yogurts/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
