namespace YogurtFinder.Models
{
  public class Nutrition
  {
    public int NutritionId { get; set; }
    public int YogurtId { get; set; }
    public string Protein { get; set; }
    public string Sugar { get; set; }
    public string Fat { get; set; }
    public string Carbs { get; set; }
    public string Calories { get; set; }
    public virtual Yogurt Yogurt { get; set; }
  }
}