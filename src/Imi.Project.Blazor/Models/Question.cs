namespace Imi.Project.Blazor.Models
{
    public class Question : BaseEntity
    {
        public string QuestionText { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}