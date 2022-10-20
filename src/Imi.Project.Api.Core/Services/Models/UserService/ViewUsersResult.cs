using Imi.Project.Api.Core.Entities;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Services.Models.UserService
{
    public class ViewUsersResult : ResultBase
    {
        public IEnumerable<User> Users { get; set; }
    }
}