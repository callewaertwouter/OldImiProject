﻿using Imi.Project.Mobile.Domain.Models;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services
{
    public interface IUserService
    {
        Task<User> GetUser(Guid id);

        Task<User> UpdateUser(User user);
    }
}