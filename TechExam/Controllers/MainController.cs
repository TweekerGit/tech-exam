using Microsoft.AspNetCore.Mvc;
using TechExam.Services;

namespace TechExam.Controllers;

[ApiController]
[Route("[controller]")]
public class MainController : Controller
{
    private readonly TestService _service;

    public MainController(TestService service)
    {
        _service = service;
    }

    [HttpGet]
    [ApiExplorerSettings(IgnoreApi = true)]
    public IActionResult Swagger()
    {
        return Redirect("/swagger");
    }

    [HttpGet("start")]
    public IActionResult Start()
    {
        return Ok("Success");
    }
}