public class Review
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public string GeoLocation { get; set; }
    public DateTime Date { get; set; }
    public int Rating { get; set; }
    public double Price { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public List<Picture> Pics { get; set; }
    public string Insta { get; set; }
    public List<ReviewIngredient> ReviewIngredients { get; set; }
}