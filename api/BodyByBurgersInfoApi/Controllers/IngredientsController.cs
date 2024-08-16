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
    public async Task<ActionResult<IEnumerable<IngredientDto>>> Get([FromQuery] string query = "", [FromQuery] bool isTop = false)
    {
        if(isTop && !string.IsNullOrEmpty(query)){
            return BadRequest("Cannot filter by query and top five at the same time");
        }
        if (!string.IsNullOrEmpty(query))
        {
            return Ok(await _ingredientService.GetAsync());
        }
        else if(isTop){
            var topRecs = (await _ingredientService.GetAsync()).Take(6);
            return Ok(topRecs); //todo implement top 5 by sum being used on all reviews
        } 
        
        return Ok(await _ingredientService.GetAsync(i => i.Name.ToLower().StartsWith(query.ToLower())));
    }

    [HttpPost]
    public async Task<ActionResult<IngredientDto>> Post([FromBody] IngredientDto ingredientDto)
    {
        var createdIngredient = await _ingredientService.CreateAsync(ingredientDto);
        return CreatedAtAction(nameof(Get), new { id = createdIngredient.Id }, createdIngredient);
    }
}
