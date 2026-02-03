using System;
using QuizMaster.Application.DTOs;
using QuizMaster.Application.Interfaces;
using QuizMaster.Domain.Entities;
namespace QuizMaster.Application.Features.QuizService
{
    public class QuizService : IQuizService
    {

        public Guid CreateQuiz(CreateQuizRequest request)
        {
            var quiz = new Quiz(request.UserId, request.Category);
            return quiz.Id;
        }
    }
}

