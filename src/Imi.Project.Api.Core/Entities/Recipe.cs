using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Entities
{
    public class Recipe : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        // Many recipes will use many ingedriënts
        public ICollection<Ingedrient> Ingedrients { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
