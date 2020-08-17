namespace Yogurt.Models
{
  public class Yogurt
  {
    public int YogurtId { get; set; }
    public int NutritionId { get; set; }
    public string Brand { get; set; }
    public string Flavor { get; set; }
    public bool Blended { get; set; }
    public string Type { get; set; }
    public Nutrition Nutrition { get; set; }
  }
}