namespace Imi.Project.Blazor.Models.Concepts
{
    public class Question : BaseEntity
    {
        public string QuestionText { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}