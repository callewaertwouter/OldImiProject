using Microsoft.AspNetCore.Components;

namespace Imi.Project.Blazor.Models.Concepts
{
    // Giving this class the name "QuizBase" so it doesn't have matching names with Quiz.razor
    public class QuizBase : ComponentBase
    {
        public List<Question> Questions { get; set; } = new List<Question>();

        protected int questionIndex = 0;
        protected int questionCount = 1;
        protected int quizScore = 0;

        protected override Task OnInitializedAsync()
        {
            LoadQuestions();

            return base.OnInitializedAsync();
        }

        protected void SelectedChoice(string choice)
        {
            if (choice == Questions[questionIndex].Answer)
            {
                quizScore++;
            }
            questionIndex++;
            questionCount++;
        }

        private void LoadQuestions()
        {
            Question question1 = new Question
            {
                QuestionTitle = "Tot welke soort behoort keukenzout?",
                Choices = new List<string>() { "Kruid", "Smaakversterker", "Groente" },
                Answer = "Smaakversterker"
            };

            Question question2 = new Question
            {
                QuestionTitle = "Waar komen hotdogs origineel van?",
                Choices = new List<string>() { "Amerika", "Engeland", "Ierland", "Duitsland" },
                Answer = "Duitsland"
            };

            Question question3 = new Question
            {
                QuestionTitle = "Wat betekent het japanse woord 'Nori'?",
                Choices = new List<string>() { "Zeewier", "Boter", "Mossel", "Vogelborst" },
                Answer = "Zeewier"
            };

            Question question4 = new Question
            {
                QuestionTitle = "Welke saus wordt traditioneel gebruikt voor eieren Benedict?",
                Choices = new List<string>() { "Witte saus", "Hollandaisesaus", "Barbecausaus" },
                Answer = "Hollandaisesaus"
            };

            Question question5 = new Question
            {
                QuestionTitle = "Waar komt graan vandaan?",
                Choices = new List<string>() { "Van de bomen", "Van de struiken", "Van de velden", "Van de dieren" },
                Answer = "Van de velden"
            };

            Question question6 = new Question
            {
                QuestionTitle = "Is deze quiz de beste quiz ooit?",
                Choices = new List<string>() { "Jaaa!!!", "Nee zeg..." },
                Answer = "Jaaa!!!"
            };

            Questions.AddRange(new List<Question> { question1, question2, question3, question4, question5, question6 });
        }
    }
}