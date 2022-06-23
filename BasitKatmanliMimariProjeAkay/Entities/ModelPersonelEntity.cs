using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BasitKatmanliMimariProjeAkay.Entities
{
    public partial class ModelPersonelEntity : DbContext
    {
        public ModelPersonelEntity()
            : base("name=ModelPersonelEntity")
        {
        }

        public virtual DbSet<Birimler> Birimlers { get; set; }
        public virtual DbSet<Personeller> Personellers { get; set; }
        public virtual DbSet<ViewPersonelBirim> ViewPersonelBirims { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Birimler>()
                .Property(e => e.BirimAd)
                .IsUnicode(false);

            modelBuilder.Entity<Birimler>()
                .Property(e => e.Aciklama)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.AdSoyad)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.Telefon)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.aDRES)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ViewPersonelBirim>()
                .Property(e => e.AdSoyad)
                .IsUnicode(false);

            modelBuilder.Entity<ViewPersonelBirim>()
                .Property(e => e.Telefon)
                .IsUnicode(false);

            modelBuilder.Entity<ViewPersonelBirim>()
                .Property(e => e.aDRES)
                .IsUnicode(false);

            modelBuilder.Entity<ViewPersonelBirim>()
                .Property(e => e.BirimAd)
                .IsUnicode(false);
        }
    }
}
