public class Review
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public string GeoLocation { get; set; }
    public DateTimeOffset Date { get; set; }
    public decimal Rating { get; set; }
    public decimal Price { get; set; }
    public ICollection<Ingredient> Ingredients { get; set; } = [];
    public List<Picture> Pics { get; set; }
    public string Insta { get; set; }

}