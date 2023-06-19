﻿using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure;
using Imi.Project.Api.Core.Services.Interfaces;
using Imi.Project.Api.Core.Services.Models.UserService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ViewUsersResult> GetAllUsers()
        {
            var result = new ViewUsersResult();
            result.ValidationResults = new List<ValidationResult>();

            result.Users = await _userRepository.ListAllAsync();
            result.IsSuccess = true;

            return result;
        }

        public async Task<ViewUsersResult> GetUserById(Guid id)
        {
            var result = new ViewUsersResult();
            var validationResults = new List<ValidationResult>();

            var user = await _userRepository.GetByIdAsync(id);

            if (user == null)
            {
                validationResults.Add(new ValidationResult($"User with id {id} is not found."));
                result.IsSuccess = false;
            }
            else
            {
                var users = new List<User>();
                users.Add(user);
                result.Users = users;
                result.IsSuccess = true;
            }

            result.ValidationResults = validationResults;

            return result;
        }

        public async Task<ViewUsersResult> SearchUserByName(string searchInput)
        {
            var result = new ViewUsersResult();
            var validationResults = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(searchInput))
            {
                validationResults.Add(new ValidationResult($"No searchtext provided!"));
                result.IsSuccess = false;
            }
            else if (searchInput.Length <= 2)
            {
                validationResults.Add(new ValidationResult($"At least 3 characters are required to search for users."));
                result.IsSuccess = false;
            }
            else
            {
                var users = await _userRepository.SearchAsync(searchInput);
                result.Users = users;
                result.IsSuccess = true;
            }

            result.ValidationResults = validationResults;
            return result;
        }
    }
}
