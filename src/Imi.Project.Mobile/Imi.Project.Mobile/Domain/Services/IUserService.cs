using Imi.Project.Mobile.Domain.Models;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services
{
    public interface IUserService
    {
        Task<User> GetUser(Guid id);

        //TODO: Maybe add UpdateUser and DeleteUser later if required or enough time left in december
    }
}