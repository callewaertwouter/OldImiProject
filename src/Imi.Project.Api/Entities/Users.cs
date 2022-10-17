using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Entities
{
    public class Users : BaseEntity
    {
        [Required]
        public string Email { get; set; }

        // Not setting a password for now since it's just a simple login functionality and only meant to show users keeping created recipes in database.
    }
}
