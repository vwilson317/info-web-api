using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace BodyByBurgersInfoApi.BusinessLogic
{
    public class IngredientService: ServiceBase<Ingredient, IngredientDto>, IService<Ingredient, IngredientDto>
    {
        public IngredientService(InfoContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}