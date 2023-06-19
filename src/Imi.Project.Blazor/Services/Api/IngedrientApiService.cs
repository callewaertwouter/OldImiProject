using Imi.Project.Api.Core.DTOs.Ingedrient;
using Imi.Project.Api.Core.DTOs.Recipe;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Blazor.Services.Crud;

namespace Imi.Project.Blazor.Services.Api;

public class IngedrientApiService : ICRUDService<Ingedrient>
{
    private string baseUrl = "https://localhost:5001/api/ingedrients";
    private readonly HttpClient _httpClient;

    public IngedrientApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Ingedrient> Get(Guid id)
    {
        var dto = await _httpClient.GetFromJsonAsync<IngedrientRequestDto>($"{baseUrl}/{id}");

#pragma warning disable CS8602 // Dereference of a possibly null reference.
        return new Ingedrient
        {
            Id = dto.Id,
            Name = dto.Name
        };
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }

    public async Task<IQueryable<Ingedrient>> GetAll()
    {
        var dtos = await _httpClient.GetFromJsonAsync<IngedrientRequestDto[]>($"{baseUrl}");

#pragma warning disable CS8604 // Possible null reference argument.
        return dtos.Select(dto => new Ingedrient
        {
            Id = dto.Id,
            Name = dto.Name
        }).AsQueryable();
#pragma warning restore CS8604 // Possible null reference argument.
    }

    public Task Create(Ingedrient item)
    {
        var dto = new IngedrientRequestDto
        {
            Id = Guid.NewGuid(),
            Name = item.Name
        };

        return _httpClient.PostAsJsonAsync($"{baseUrl}", dto);
    }

    public Task Update(Ingedrient item)
    {
        var dto = new IngedrientRequestDto
        {
            Name = item.Name
        };

        return _httpClient.PutAsJsonAsync($"{baseUrl}/{item.Id}", dto);
    }

    public Task Delete(Guid id)
    {
        return _httpClient.DeleteAsync($"{baseUrl}/{id}");
    }
}
