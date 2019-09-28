using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OT2.Models
{
    public class OT2Context : DbContext
    {
        public OT2Context (DbContextOptions<OT2Context> options)
            : base(options)
        {
        }

        public DbSet<OT2.Models.Emp> Emp { get; set; }
    }
}
