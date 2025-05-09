using ECommerce.Application.Contract.Dto.Catalog;
using ECommerce.Application.Contract.Interfaces.Catalog;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers.Catalog;

[Route("api/[controller]")]
[ApiController]
public class FeatureController : ControllerBase
{
    private readonly IFeatureService featureService;

    public FeatureController(IFeatureService featureService)
    {
        this.featureService = featureService;
    }
    [HttpPost]

    public async Task<IActionResult> AddFeature(FeatureDto feature)
    { 
        await featureService.Add(feature);
        return Ok(feature);
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await featureService.GetById(id);
        return Ok(result);
    }
}
