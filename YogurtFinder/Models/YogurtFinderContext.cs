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

    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Yogurt>()
        .HasData(
          new Yogurt { YogurtId = 1, Brand = "Ellenos", Flavor = "key lime", Blended = false, Type = "greek", Protein = 16, Sugar = 30, Fat = 17, Carbs = 38, Calories = 360 },
          new Yogurt { YogurtId = 2, Brand = "Brown Cow", Flavor = "plain", Blended = false, Type = "cream top", Protein = 8, Sugar = 7, Fat = 3, Carbs = 11, Calories = 130 },
          new Yogurt { YogurtId = 3, Brand = "Siggi", Flavor = "coffee", Blended = true, Type = "icelandic", Protein = 13, Sugar = 8, Fat = 5, Carbs = 11, Calories = 140 },
          new Yogurt { YogurtId = 4, Brand = "CoCoYo", Flavor = "vanilla", Blended = false, Type = "dairy free", Protein = 1, Sugar = 2, Fat = 6, Carbs = 8, Calories = 90 },
          new Yogurt { YogurtId = 5, Brand = "Chobani Flip", Flavor = "cookie dough", Blended = false, Type = "dessert, greek", Protein = 11, Sugar = 21, Fat = 5, Carbs = 24, Calories = 190 }
        );
    }
  }
}