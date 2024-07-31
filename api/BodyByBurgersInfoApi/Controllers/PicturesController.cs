using BodyByBurgersInfoApi.BusinessLogic;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PicturesController : ControllerBase
{
    private readonly ILogger<PicturesController> _logger;
    private IService<Picture, PictureDto> _pictureService;

    public PicturesController(ILogger<PicturesController> logger, IService<Picture, PictureDto> pictureService)
    {
        _logger = logger;
        _pictureService = pictureService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Picture>>> Get()
    {
        var results = await _pictureService.GetAsync();
        return Ok(results);
    }
}