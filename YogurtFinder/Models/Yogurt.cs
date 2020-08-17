using System.Collections.Generic;

namespace YogurtFinder.Models
{
  public class Yogurt
  {
    public Yogurt ()
    {
    this.Nutritions = new HashSet<Nutrition>();
    }

    public int YogurtId { get; set; }
    public int NutritionId { get; set; }
    public string Brand { get; set; }
    public string Flavor { get; set; }
    public bool Blended { get; set; }
    public string Type { get; set; }
    // public Nutrition Nutrition { get; set; }
    public virtual Nutrition Nutrition {get; set; }  
    }
  }