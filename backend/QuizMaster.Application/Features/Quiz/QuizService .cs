using System;
using QuizMaster.Application.DTOs;
using QuizMaster.Application.Interfaces;
using QuizMaster.Domain.Entities;

namespace QuizMaster.Application.Features.Quiz
{
    public class QuizService : IQuizService
    {

        public Guid CreateQuiz(CreateQuizRequest request)
        {
            var quiz = new QuizMaster.Domain.Entities.Quiz(request.UserId, request.Category);
            return quiz.Id;
        }
    }
}

