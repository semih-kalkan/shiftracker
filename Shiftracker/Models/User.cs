using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShifTracker.Models
{
    [Table("user")]
    public class User
    {
        
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("empId")]
        public string EmpId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("surname")]
        public string Surname { get; set; }

    }
}
