using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entities;

namespace DataAccessLayer
{
    public class Context:DbContext
    {
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Departman> Departmans { get; set; }
    }
}
