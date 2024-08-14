using Newtonsoft.Json;

public class ReviewDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public string GeoLocation { get; set; }
    public DateTimeOffset Date { get; set; }
    public decimal Rating { get; set; }
    public decimal Price { get; set; }
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public List<IngredientDto> Ingredients { get; set; } = null;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public List<Picture> Pics { get; set; } = null;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string Insta { get; set; } = null;
}