using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Infrastructure
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> SearchAsync(string search);

        IQueryable<User> GetAll();

        Task<IEnumerable<User>> ListAllAsync();

        Task<User> GetByIdAsync(Guid id);

        Task<User> UpdateAsync(User entity);

        Task<User> AddAsync(User entity);

        Task<User> DeleteAsync(User entity);
    }
}