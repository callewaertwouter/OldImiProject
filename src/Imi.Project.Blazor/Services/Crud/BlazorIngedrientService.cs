using Imi.Project.Blazor.Models.Mocking;
using Imi.Project.Blazor.Pages;

namespace Imi.Project.Blazor.Services.Crud
{
    public class BlazorIngedrientService : ICRUDService<MockIngedrient>
    {
        static List<MockIngedrient> ingedrients = new List<MockIngedrient>
        {
            new MockIngedrient() { Id =  Guid.NewGuid(), Name = "liter" },
            new MockIngedrient() { Id =  Guid.NewGuid(), Name = "gram" },
            new MockIngedrient() { Id =  Guid.NewGuid(), Name = "kilogram" },
            new MockIngedrient() { Id =  Guid.NewGuid(), Name = "centiliter" },
            new MockIngedrient() { Id =  Guid.NewGuid(), Name = "takje(s)" }
        };

        public Task<MockIngedrient> Get(Guid id)
        {
            return Task.FromResult(
                ingedrients.SingleOrDefault(x => x.Id == id)
                );
        }

        public Task<IQueryable<MockIngedrient>> GetAll()
        {
            return Task.FromResult(
                ingedrients.Select(x => new MockIngedrient()
                {
                    Id = x.Id,
                    Name = x.Name,
                }).AsQueryable()
                );
        }

        public Task Create(MockIngedrient item)
        {
            item.Id = Guid.NewGuid();
            ingedrients.Add(item);
            return Task.CompletedTask;
        }

        public Task Update(MockIngedrient item)
        {
            var ingedrient = ingedrients.SingleOrDefault(x => x.Id == item.Id);

            if (ingedrient == null) throw new ArgumentException("Ingedrient not found...");

            ingedrient.Name = item.Name;

            return Task.CompletedTask;
        }

        public Task Delete(Guid id)
        {
            var ingedrient = ingedrients.SingleOrDefault(x => x.Id == id);

            if (ingedrient == null) throw new ArgumentException("Ingedrient not found...");

            ingedrients.Remove(ingedrient);
            return Task.CompletedTask;
        }
    }
}
