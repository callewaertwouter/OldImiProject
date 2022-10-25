using Imi.Project.Api.Core.Entities;

namespace Imi.Project.Blazor.Services.Crud
{
    public class BlazorUserService : ICRUDService<User>
    {
        static List<User> users = new List<User>();

        public Task<User> Get(Guid id)
        {
            return Task.FromResult(
                users.SingleOrDefault(x => x.Id == id)
                );
        }

        public Task<IQueryable<User>> GetAll()
        {
            return Task.FromResult(
                users.Select(x => new User()
                {
                    Id = x.Id,
                    Email = x.Email,
                    CreatedRecipes = x.CreatedRecipes
                }).AsQueryable()
                );
        }

        public Task Create(User item)
        {
            item.Id = Guid.NewGuid();
            users.Add(item);
            return Task.CompletedTask;
        }

        public Task Update(User item)
        {
            var user = users.SingleOrDefault(x => x.Id == item.Id);

            if (user == null) throw new ArgumentException("User not found...");

            user.Email = item.Email;
            // I don't think a new user will have created recipes already, so not including those

            return Task.CompletedTask;
        }

        public Task Delete(Guid id)
        {
            var user = users.SingleOrDefault(x => x.Id == id);

            if (user == null) throw new ArgumentException("User not found...");

            users.Remove(user);
            return Task.CompletedTask;
        }
    }
}
