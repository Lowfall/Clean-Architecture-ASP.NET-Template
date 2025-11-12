using Microsoft.AspNetCore.Mvc;

namespace Template.API.Controllers;

[Route("api/test")]
public class DefaultController : Controller
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello, this is clean architecture template!");
    }
}