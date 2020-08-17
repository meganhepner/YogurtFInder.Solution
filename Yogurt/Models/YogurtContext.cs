using Microsoft.EntityFrameworkCore;

namespace Yogurt.Models
{
  public class YogurtContext : DbContext
  {
    public YogurtContext(DbContextOptions<YogurtContext> options)
        : base(options)
        {

        }

        public DbSet<Yogurt> Yogurts { get; set; }

        // protected override void OnMOdelCreating(ModelBuilder builder)
        // {

        // }
  }
}