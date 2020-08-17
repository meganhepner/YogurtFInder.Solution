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
    public class NutritionsController : ControllerBase
    {
      private YogurtFinderContext _db;
      public NutritionsController(YogurtFinderContext db)
      {
        _db = db;
      }
        // GET api/nutritions
        [HttpGet]
        public ActionResult<IEnumerable<Nutrition>> Get(string protein, string sugar, string fat, string carbs, string calories)
        {
          var query = _db.Nutritions.AsQueryable();

          if (brand != null)
          {
          query = query.Where(entry => entry.Brand == brand);
          }
          if (flavor != null)
          {
          query = query.Where(entry => entry.Flavor == flavor);
          }
          if (blended != null)
          {
          query = query.Where(entry => entry.Blended == blended);
          }
          if (type != null)
          {
          query = query.Where(entry => entry.Type == type);
          }
            return query.ToList();
        }

        // GET api/nutritions/5
        [HttpGet("{id}")]
        public ActionResult<Nutrition> Get(int id)
        {
            return _db.Nutritions.FirstOrDefault(entry => entry.NutritionId == id);
        }

        // POST api/nutritions
        [HttpPost]
        public void Post([FromBody] Nutrition nutrition)
        {
          _db.Nutritions.Add(nutrition);
          _db.SaveChanges();
        }

        // PUT api/nutritions/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Nutrition nutrition)
        {
          nutrition.NutritionId = id;
          _db.Entry(Nutrition).State = EntityState.Modified;
          _db.SaveChanges();
        }

        // DELETE api/nutritions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
          var nutritionToDelete = _db.Nutritions.FirstOrDefault(entry => entry.NutritionId == id);
          _db.Nutritions.Remove(nutritionToDelete);
          _db.SaveChanges();
        }
    }
}