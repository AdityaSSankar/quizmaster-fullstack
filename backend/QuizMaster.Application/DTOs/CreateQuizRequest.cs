using System;

namespace QuizMaster.Application.DTOs
{
    public class CreateQuizRequest
    {
        public Guid UserId { get; set; }
        public string Category { get; set; }
    }
}
