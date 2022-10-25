using Imi.Project.Api.Core.Entities;

namespace Imi.Project.Blazor.Models
{
    public class Quiz : BaseEntity
    {
        public ICollection<Question> Questions { get; set; }
        public Guid UserId { get; set; }
        public User Users { get; set; }
    }
}