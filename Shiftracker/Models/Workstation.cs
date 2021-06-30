using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShifTracker.Models
{
    public class Workstation
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Workstation Name")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Workstation Location")]
        public string Location { get; set; }

        public List<Shift> Shifts { get; set; }
    }
}
