using Microsoft.EntityFrameworkCore;
using MaintenancePortal.Models;
using System.Collections.Generic;

namespace MaintenancePortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<School> Schools { get; set; }
    }
}
