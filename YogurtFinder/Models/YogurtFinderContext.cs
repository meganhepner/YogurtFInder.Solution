using Microsoft.EntityFrameworkCore;

namespace YogurtFinder.Models
{
  public class YogurtFinderContext : DbContext
  {
    public YogurtFinderContext(DbContextOptions<YogurtFinderContext> options)
        : base(options)
        {

        }

        public DbSet<Yogurt> Yogurts { get; set; }

        // protected override void OnModelCreating(ModelBuilder builder)
        // {

        // }
  }
}