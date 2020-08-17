using System.Collections.Generic;

namespace YogurtFinder.Models
{
  public class Yogurt
  {

    public int YogurtId { get; set; }
    public int NutritionId { get; set; }
    public string Brand { get; set; }
    public string Flavor { get; set; }
    public bool Blended { get; set; }
    public string Type { get; set; }
    public string Protein { get; set; }
    public string Sugar { get; set; }
    public string Fat { get; set; }
    public string Carbs { get; set; }
    public string Calories { get; set; } 
    }
  }