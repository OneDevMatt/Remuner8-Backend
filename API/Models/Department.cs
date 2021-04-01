﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace API.Models
{
    public partial class Department
    {
        public Department()
        {
            EmployeeBiodatas = new HashSet<EmployeeBiodata>();
        }

        [Key]
        [Column("departmentId")]
        public int DepartmentId { get; set; }

        [Required]
        [Column("departmentName")]
        [StringLength(50)]
        public string DepartmentName { get; set; }

        [InverseProperty(nameof(EmployeeBiodata.Department))]
        public virtual ICollection<EmployeeBiodata> EmployeeBiodatas { get; set; }
    }
}