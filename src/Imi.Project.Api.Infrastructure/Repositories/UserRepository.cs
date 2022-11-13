﻿using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        protected readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Since there's already a GetAll from BaseRepository, override allows it to change just the code
        public IQueryable<User> GetAll()
        {
            return _dbContext.Users.Include(u => u.CreatedRecipes);
        }

        public async Task<IEnumerable<User>> ListAllAsync()
        {
            var users = await GetAll().ToListAsync();

            return users;
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            var user = await GetAll().SingleOrDefaultAsync(r => r.Id.Equals(id));

            return user;
        }

        // Functions below appear only in this interface, so no override needed
        public async Task<IEnumerable<User>> SearchAsync(string search)
        {
            var users = await GetAll()
                                .Where(u => u.Email.Contains(search.Trim().ToUpper()))
                                .ToListAsync();

            return users;
        }

        public async Task<User> UpdateAsync(User entity)
        {
            _dbContext.Set<User>().Update(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<User> AddAsync(User entity)
        {
            _dbContext.Set<User>().Add(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<User> DeleteAsync(User entity)
        {
            _dbContext.Set<User>().Remove(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }
    }
}