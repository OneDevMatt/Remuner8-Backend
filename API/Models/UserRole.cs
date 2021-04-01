﻿using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace API.Models
{
    [Index(nameof(Role), Name = "UQ__UserRole__863D21484D4C2003", IsUnique = true)]
    public partial class UserRole
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("role")]
        [StringLength(30)]
        public string Role { get; set; }
    }
}