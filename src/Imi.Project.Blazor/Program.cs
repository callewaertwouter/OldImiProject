using Imi.Project.Blazor.Models;
using Imi.Project.Blazor.Models.Concepts;
using Imi.Project.Blazor.Models.Mocking;
using Imi.Project.Blazor.Services.Concepts;
using Imi.Project.Blazor.Services.Crud;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddTransient<ICRUDService<MockRecipe>, BlazorRecipeService>();
builder.Services.AddTransient<ICRUDService<MockUser>, BlazorUserService>();
builder.Services.AddTransient<IQuizService<Quiz>, QuizService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();