using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marketing_Sc.Entidades;

namespace Marketing_Sc.Data
{
    public class Marketing_ScContext : DbContext
    {
        public Marketing_ScContext (DbContextOptions<Marketing_ScContext> options)
            : base(options)
        {
        }

        public DbSet<Marketing_Sc.Entidades.Campania> Campania { get; set; } = default!;
    }
}
