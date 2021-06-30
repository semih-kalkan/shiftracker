using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShifTracker.Models
{
    public class Login
    {
        [Key]
        public int UserId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string Password { get; set; }
    }
}
