using BodyByBurgersInfoApi.BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace BodyByBurgersInfoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IngredientsController : ControllerBase
{
    private readonly ILogger<IngredientsController> _logger;
    private IIngredientService _ingredientService;

    public IngredientsController(ILogger<IngredientsController> logger, IIngredientService ingredientService)
    {
        _logger = logger;
        _ingredientService = ingredientService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Ingredient>>> Get()
    {
        var results = await _ingredientService.GetIngredientsAsync();
        return Ok(results);
    }
}
