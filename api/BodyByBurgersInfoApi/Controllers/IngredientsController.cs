using BodyByBurgersInfoApi.BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace BodyByBurgersInfoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IngredientsController : ControllerBase
{
    private readonly ILogger<IngredientsController> _logger;
    private IService<Ingredient, IngredientDto> _ingredientService;

    public IngredientsController(ILogger<IngredientsController> logger, IService<Ingredient, IngredientDto> ingredientService)
    {
        _logger = logger;
        _ingredientService = ingredientService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<IngredientDto>>> Get()
    {
        var results = await _ingredientService.GetAsync();
        return Ok(results);
    }
}
