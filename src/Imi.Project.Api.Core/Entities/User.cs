using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities
{
    public class User : IdentityUser
    {
        public string Password { get; set; }

        public DateTime Birthday { get; set; }

        public bool HasApprovedTermsAndConditions { get; set; }

        public ICollection<Recipe> CreatedRecipes { get; set; }
    }
}