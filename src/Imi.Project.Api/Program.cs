using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure;
using Imi.Project.Api.Core.Services;
using Imi.Project.Api.Core.Services.Interfaces;
using Imi.Project.Api.Infrastructure.Data;
using Imi.Project.Api.Infrastructure.Repositories;
using Imi.Project.Api.Policies;
using Imi.Project.Api.Policies.Handlers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ImiDb")));

builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
builder.Services.AddScoped<IIngedrientRepository, IngedrientRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUnitOfMeasureRepository, UnitOfMeasureRepository>();

builder.Services.AddScoped<IRecipeService, RecipeService>();
builder.Services.AddScoped<IIngedrientService, IngedrientService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddSingleton<IAuthorizationHandler, MinimumAgeHandler>();

builder.Services.AddCors();

// Identity configuration
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedEmail = false;
})
    .AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(jwtOptions =>
    {
        jwtOptions.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateActor = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = builder.Configuration["JWTConfiguration:Issuer"],
            ValidAudience = builder.Configuration["JWTConfiguration:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWTConfiguration:SigninKey"]))
        };
    });

// User Policies
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Admin", policy =>
    {
        policy.RequireClaim(ClaimTypes.Role, "admin");
    });

    options.AddPolicy("User", policy =>
    {
        policy.RequireAssertion(context =>
        {
            if (context.User.HasClaim(ClaimTypes.Role, "admin") || context.User.HasClaim(ClaimTypes.Role, "user"))
            {
                return true;
            }
            return false;
        });
    });

    options.AddPolicy("Over15Only", policy =>
    {
        policy.Requirements.Add(new MinimumAgeRequirement(15));
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseCors(builder => builder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod());
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
