using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShifTracker.Models
{
    public class ShifTrackerDbContext:DbContext
    {
        public ShifTrackerDbContext(DbContextOptions<ShifTrackerDbContext> options) : base(options)
        {

        }
        public DbSet<Workstation> Workstations { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
