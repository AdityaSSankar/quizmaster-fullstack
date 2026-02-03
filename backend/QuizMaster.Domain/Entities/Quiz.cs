using System;

namespace QuizMaster.Domain.Entities
{
    public class Quiz
    {
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public string Category { get; private set; }
        public int TotalScore { get; private set; }

        private Quiz() { } // Required by EF Core

        public Quiz(Guid userId, string category)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Category = category;
            TotalScore = 0;
        }

        public void AddScore(int points)
        {
            TotalScore += points;
        }
    }
}
