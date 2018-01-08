using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class WorkersDbContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
    }
}
