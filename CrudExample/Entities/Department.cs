using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrudExample.Entities
{
    [Table("Department")]
    [Index(nameof(DepartmentId), Name = "IX_Department")]
    public partial class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? DepartmentName { get; set; }
    }
}
