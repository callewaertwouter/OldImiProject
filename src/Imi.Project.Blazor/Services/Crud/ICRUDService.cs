namespace Imi.Project.Blazor.Services.Crud
{
    public interface ICRUDService<T> where T : class
    {
        Task<IQueryable<T>> GetAll();

        Task<T> Get(int id);

        Task Create(T item);

        Task Update(T item);

        Task Delete(int id);
    }
}