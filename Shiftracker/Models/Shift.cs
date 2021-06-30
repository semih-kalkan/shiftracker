using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShifTracker.Models
{
    public class Shift
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "smalldatetime")]
        [Required]
        public DateTime StartTime { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EndTime { get; set; }

        public int WorkstationId { get; set; }
        public Workstation Workstation { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
