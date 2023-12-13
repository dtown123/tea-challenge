using Microsoft.AspNetCore.Mvc;
using TEAChallenge.Services;

namespace TEAChallenge.Host.Controllers;

[ApiController]
[Route("students")]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _studentService;
    
    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var students = await _studentService.GetStudentGPAsAsync();
        
        return Ok(students);
    }
}