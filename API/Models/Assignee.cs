﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("Assignee")]
    public partial class Assignee
    {
        [Key]
        [Column("assigneeId")]
        public int AssigneeId { get; set; }
        [Required]
        [Column("assigneeName")]
        [StringLength(30)]
        public string AssigneeName { get; set; }
    }
}
