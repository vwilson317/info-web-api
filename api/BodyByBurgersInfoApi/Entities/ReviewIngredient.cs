public class ReviewIngredient
{
    public int Id { get; set; }
    public int ReviewId { get; set; }
    public int IngredientId { get; set; }
    public Review Review { get; set; }
    public Ingredient Ingredient { get; set; }
}