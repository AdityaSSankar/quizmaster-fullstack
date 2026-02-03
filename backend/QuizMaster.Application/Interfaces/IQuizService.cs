using System;
using QuizMaster.Application.DTOs;
namespace QuizMaster.Application.Interfaces 
{
    public interface IQuizService
    {

        Guid CreateQuiz(CreateQuizRequest request);

    }

}
