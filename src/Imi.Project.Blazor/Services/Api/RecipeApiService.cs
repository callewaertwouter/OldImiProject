﻿using Imi.Project.Api.Core.DTOs.Recipe;
using Imi.Project.Api.Core.DTOs.Ingedrient;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Blazor.Services.Crud;
using Imi.Project.Api.Core.DTOs.User;

namespace Imi.Project.Blazor.Services.Api;

public class RecipeApiService : ICRUDService<Recipe>
{
    private string baseUrl = "https://localhost:5001/api/recipes";
    private readonly HttpClient _httpClient;

    public RecipeApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Recipe> Get(Guid id)
    {
        var dto = await _httpClient.GetFromJsonAsync<RecipeRequestDto>($"{baseUrl}/{id}");

#pragma warning disable CS8602 // Dereference of a possibly null reference.
        return new Recipe
        {
            Id = dto.Id,
            Title = dto.Title,
            Description = dto.Description
        };
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }

    public async Task<IQueryable<Recipe>> GetAll()
    {
        var dtos = await _httpClient.GetFromJsonAsync<RecipeRequestDto[]>($"{baseUrl}");

#pragma warning disable CS8604 // Possible null reference argument.
        return dtos.Select(dto => new Recipe
        {
            Id = dto.Id,
            Title = dto.Title,
            Description = dto.Description

        }).AsQueryable();
#pragma warning restore CS8604 // Possible null reference argument.
    }

    public Task Create(Recipe item)
    {
        var dto = new RecipeRequestDto
        {
            Id = Guid.NewGuid(),
            Title = item.Title,
            Description = item.Description
        };

        return _httpClient.PostAsJsonAsync($"{baseUrl}", dto);
    }

    public Task Update(Recipe item)
    {
        var dto = new RecipeRequestDto
        {
            Title = item.Title,
            Description = item.Description
        };

        return _httpClient.PutAsJsonAsync($"{baseUrl}/{item.Id}", dto);
    }

    public Task Delete(Guid id)
    {
        return _httpClient.DeleteAsync($"{baseUrl}/{id}");
    }
}
