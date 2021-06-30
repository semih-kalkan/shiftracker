using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShifTracker.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Employee Name")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Employee Surname")]
        public string Surname { get; set; }

        public List<Shift> Shifts { get; set; }
    }
}
