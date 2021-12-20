using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using TechExam.Services;
using TechExam.sqrt.Models;

namespace TechExam.Controllers;

[ApiController]
[Route("[controller]")]
public class MainController : Controller
{
    private readonly ProgressionService _service;

    public MainController(ProgressionService service)
    {
        _service = service;
    }

    [HttpGet("/")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public IActionResult Swagger()
    {
        return Redirect("/swagger");
    }

    [HttpGet("n-element")]
    public IActionResult GetNElement(int nElement)
    {
        try
        {
            return Ok(new ProgressionResponse {Result = _service.GetNElement(nElement)});
        }
        catch (Exception e)
        {
            return BadRequest($"Error: {e.Message}");
        }
    }

    [HttpPost("progression")]
    public IActionResult Progression(ProgressionRequest request)
    {
        try
        {
            return Ok(new ProgressionResponse
                {Result = _service.GetNElement(request.NElement, request.First, request.Difference)});
        }
        catch (Exception e)
        {
            return BadRequest($"Error: {e.Message}");
        }
    }
}