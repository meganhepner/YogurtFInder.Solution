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

    [HttpGet] //PAGINATION PART 1
    public IActionResult GetAll([FromQuery] PaginationFilter filter)
    {
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
      var pagedData = _db.Yogurts.ToList()
        .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
        .Take(validFilter.PageSize)
        .ToList();
      var totalRecords = _db.Yogurts.Count();
      return Ok(new PagedResponse<List<Yogurt>>(pagedData, validFilter.PageNumber, validFilter.PageSize));
    }

    // // GET api/yogurts
    // [HttpGet]
    // public ActionResult<IEnumerable<Yogurt>> Get(string brand, string flavor, bool blended, string type)
    // {
    //   var query = _db.Yogurts.AsQueryable();

    //   if (brand != null)
    //   {
    //     query = query.Where(entry => entry.Brand.Contains(brand));
    //   }
    //   if (flavor != null)
    //   {
    //     query = query.Where(entry => entry.Flavor.Contains(flavor));
    //   }
    //   if (blended)
    //   {
    //     query = query.Where(entry => entry.Blended == blended);
    //   }
    //   if (type != null)
    //   {
    //     query = query.Where(entry => entry.Type.Contains(type));
    //   }
    //   return query.ToList();
    // }

    // GET api/yogurts/5
    [HttpGet("{id}")]
    public ActionResult<Yogurt> Get(int id)
    {
      var yogurt = _db.Yogurts.Where(a => a.YogurtId == id).FirstOrDefault(); // added for pagination
      return Ok(new Response<Yogurt>(yogurt));
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
    public void Put(int id, [FromBody] Yogurt yogurt)
    {
      yogurt.YogurtId = id;
      _db.Entry(yogurt).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/yogurts/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var yogurtToDelete = _db.Yogurts.FirstOrDefault(entry => entry.YogurtId == id);
      _db.Yogurts.Remove(yogurtToDelete);
      _db.SaveChanges();
    }
  }
}
