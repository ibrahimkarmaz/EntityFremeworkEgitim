using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CodeFirstSihirbazKullanimi
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<giris_tablosu> giris_tablosu { get; set; }
        public virtual DbSet<ilceler> ilcelers { get; set; }
        public virtual DbSet<iller> illers { get; set; }
        public virtual DbSet<MusteriTablosu> MusteriTablosus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<giris_tablosu>()
                .Property(e => e.kullanici_adi)
                .IsUnicode(false);

            modelBuilder.Entity<giris_tablosu>()
                .Property(e => e.parola)
                .IsUnicode(false);

            modelBuilder.Entity<MusteriTablosu>()
                .Property(e => e.resimyolu)
                .IsUnicode(false);
        }
    }
}
