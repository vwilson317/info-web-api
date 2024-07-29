public class Review
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public string GeoLocation { get; set; }
    public string Date { get; set; }
    public int Rating { get; set; }
    public string Price { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public List<Picture> Pics { get; set; }
    public string Insta { get; set; }
}