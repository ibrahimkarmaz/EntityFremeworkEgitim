using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrnekEF1.Entities;

namespace OrnekEF1
{
    public class Context:DbContext
    {
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Calisma> Calismas { get; set; }
    }
}
