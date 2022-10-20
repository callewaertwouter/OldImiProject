using Imi.Project.Api.Core.Services.Models.UserService;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.Interfaces
{
    public interface IUserService
    {
        Task<ViewUsersResult> GetAllUsers();
        Task<ViewUsersResult> GetUserById(Guid id);
        Task<ViewUsersResult> SearchUserByName(string searchInput);
    }
}