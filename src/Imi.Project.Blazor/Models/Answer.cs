﻿namespace Imi.Project.Blazor.Models
{
    public class Answer : BaseEntity
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}