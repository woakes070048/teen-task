﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeenTasks.Models
{
    public enum ProfileType
    {
        Employee,
        Employer
    }

    public class Profile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        public ProfileType Type { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(1)]
        [MinLength(1)]
        public string LastInitial { get; set; }

        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set; }
        public virtual ApplicationUser Owner { get; set; }
    }
}