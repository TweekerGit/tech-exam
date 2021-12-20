using Microsoft.AspNetCore.Mvc;
using TechExam.sqrt.Models;
using TechExam.sqrt.Services;

namespace TechExam.sqrt.Controllers;

[ApiController]
[Route("[controller]")]
public class SqrtController : Controller
{
    private readonly SqrtService _service;

    public SqrtController(SqrtService service)
    {
        _service = service;
    }

    [HttpGet("get-sqrt")]
    public IActionResult Sqrt(double number)
    {
        try
        {
            return Ok(new SqrtResponse {Result = _service.GetSqrt(number)});
        }
        catch (Exception e)
        {
            return BadRequest($"Error: {e.Message}");
        }
    }
}