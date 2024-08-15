using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Review
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public string GeoLocation { get; set; }
    public DateTimeOffset Date { get; set; }
    public decimal Rating { get; set; }
    public decimal Price { get; set; }
    public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    public List<Picture> Pics { get; set; } = [];
    public string Insta { get; set; }
}