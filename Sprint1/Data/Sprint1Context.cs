using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sprint1.Models;

namespace Sprint1.Data
{
    public class Sprint1Context : DbContext
    {
        public Sprint1Context (DbContextOptions<Sprint1Context> options)
            : base(options)
        {
        }

        public DbSet<Sprint1.Models.Convocatoria> Convocatoria { get; set; } = default!;
    }
}
