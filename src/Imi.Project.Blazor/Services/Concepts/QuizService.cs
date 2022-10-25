using Imi.Project.Blazor.Models;

namespace Imi.Project.Blazor.Services.Concepts
{
    public class QuizService : IQuizService
    {
        static List<Question> questions = new List<Question>
        {
            new Question() { Id = 1, QuestionText = "Tot welke soort behoort keukenzout?" },
            new Question() { Id = 2, QuestionText = "Waar komen hotdogs origineel van?" },
            new Question() { Id = 3, QuestionText = "Wat betekent het japanse woord 'Nori'?" },
            new Question() { Id = 4, QuestionText = "Welke saus wordt traditioneel gebruikt voor eieren Benedict?" },
            new Question() { Id = 5, QuestionText = "Is deze quiz de beste quiz ooit?" },
        };

        static List<Answer> answers = new List<Answer>
        {
            // Question 1
            new Answer() { Id = 1, QuestionId = 1, Text = "Kruid", IsCorrect = false },
            new Answer() { Id = 2, QuestionId = 1, Text = "Smaakversterker", IsCorrect = true },
            new Answer() { Id = 3, QuestionId = 1, Text = "Groente", IsCorrect = false },
            // Question 2
            new Answer() { Id = 4, QuestionId = 2, Text = "Amerika", IsCorrect = false },
            new Answer() { Id = 5, QuestionId = 2, Text = "Engeland", IsCorrect = false },
            new Answer() { Id = 6, QuestionId = 2, Text = "Ierland", IsCorrect = false },
            new Answer() { Id = 7, QuestionId = 2, Text = "Duitsland", IsCorrect = true },
            // Question 3
            new Answer() { Id = 8, QuestionId = 3, Text = "Zeewier", IsCorrect = true },
            new Answer() { Id = 9, QuestionId = 3, Text = "Boter", IsCorrect = false },
            new Answer() { Id = 10, QuestionId = 3, Text = "Mossel", IsCorrect = false },
            new Answer() { Id = 11, QuestionId = 3, Text = "Vogelborst", IsCorrect = false },
            // Question 4
            new Answer() { Id = 12, QuestionId = 4, Text = "Witte saus", IsCorrect = false },
            new Answer() { Id = 13, QuestionId = 4, Text = "Hollandaisesaus", IsCorrect = true },
            new Answer() { Id = 14, QuestionId = 4, Text = "Barbecuesaus", IsCorrect = false },
            // Question 5
            new Answer() { Id = 15, QuestionId = 5, Text = "Jaaa!!!", IsCorrect = true },
            new Answer() { Id = 16, QuestionId = 5, Text = "Nee zeg...", IsCorrect = false }
        };

        public Task<IQueryable> GetAllQuestions()
        {
            throw new NotImplementedException();
        }
    }
}