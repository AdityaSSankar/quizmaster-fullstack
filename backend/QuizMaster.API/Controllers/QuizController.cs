using Microsoft.AspNetCore.Mvc;
using QuizMaster.Application.DTOs;
using QuizMaster.Application.Interfaces;

namespace QuizMaster.Api.Controllers;

[ApiController]
[Route("api/quizzes")]
public class QuizController : ControllerBase
{
    private readonly IQuizService _quizService;

    public QuizController(IQuizService quizService)
    {
        _quizService = quizService;
    }

    [HttpPost]
    public IActionResult CreateQuiz([FromBody] CreateQuizRequest request)
    {
        var quizId = _quizService.CreateQuiz(request);
        return Ok(new { quizId });
    }
}
