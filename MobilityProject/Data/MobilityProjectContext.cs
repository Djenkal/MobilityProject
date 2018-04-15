using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MobilityProject.Models;

namespace MobilityProject.Models
{
    public class MobilityProjectContext : DbContext
    {
        public MobilityProjectContext (DbContextOptions<MobilityProjectContext> options)
            : base(options)
        {
        }

        public DbSet<MobilityProject.Models.Room> Room { get; set; }

        public DbSet<MobilityProject.Models.Building> Building { get; set; }
    }
}
