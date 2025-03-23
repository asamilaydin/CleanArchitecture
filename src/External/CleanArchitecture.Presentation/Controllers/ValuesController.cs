using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class ValuesConroller : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Başarılı");
    }
}