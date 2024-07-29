using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace BodyByBurgersInfoApi.BusinessLogic
{
    public class IngredientService: IIngredientService{
        private readonly InfoContext _dbContext;
        private readonly IMapper _mapper;

        public IngredientService(InfoContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<IngredientDto>> GetIngredientsAsync()
        {
            var data = await _dbContext.Ingredients.ToListAsync();
            return _mapper.Map<List<IngredientDto>>(data);
        }

        public Ingredient Create(IngredientDto ingredientDto)
        {
            var ingredient = _mapper.Map<Ingredient>(ingredientDto);
            _dbContext.Ingredients.Add(ingredient);
            _dbContext.SaveChanges();
            return ingredient;
        }
    }
}