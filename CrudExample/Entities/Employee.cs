using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrudExample.Entities
{
    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? EmployeeName { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Department { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfJoining { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? PhotoFileName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Password { get; set; }
    }
}
