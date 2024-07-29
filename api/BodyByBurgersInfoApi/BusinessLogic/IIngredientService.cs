namespace BodyByBurgersInfoApi.BusinessLogic
{
    public interface IIngredientService
    {
        Task<List<IngredientDto>> GetIngredientsAsync();
        Ingredient Create(IngredientDto ingredient);
    }
}