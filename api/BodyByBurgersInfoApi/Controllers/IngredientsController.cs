using Microsoft.AspNetCore.Mvc;

namespace BodyByBurgersInfoApi.Controllers;

[ApiController]
[Route("[controller]/api")]
public class IngredientsController : ControllerBase
{
    private readonly ILogger<IngredientsController> _logger;

    public IngredientsController(ILogger<IngredientsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Ingredient> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Ingredient
        {
            Id = index,
            Name = $"Ingredient {index}",
            Icon = "icon"
        });
    }
}
