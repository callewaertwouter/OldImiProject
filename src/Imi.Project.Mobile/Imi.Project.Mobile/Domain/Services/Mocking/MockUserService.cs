using Imi.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Mocking
{
    public class MockUserService : IUserService
    {
        private static List<User> users = new List<User>
        {
            new User{ Id=Guid.Parse("00000000-0000-0000-0000-000000000001"), Email="woutercallewaert@gmail.com" },
            new User{ Id=Guid.Parse("00000000-0000-0000-0000-000000000002"), Email="admin@admin.be" }
        };

        public async Task<User> GetUser(Guid id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            return await Task.FromResult(user);
        }

        public async Task<User> UpdateUser(User user)
        {
            var oldUser = users.FirstOrDefault(u => u.Id == user.Id);

            users.Remove(oldUser);
            users.Add(user);

            return await Task.FromResult(user);
        }
    }
}