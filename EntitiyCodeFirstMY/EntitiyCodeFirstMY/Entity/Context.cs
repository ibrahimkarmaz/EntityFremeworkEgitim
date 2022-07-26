using System.Data.Entity;

namespace EntitiyCodeFirstMY.Entity
{
    public class Context : DbContext
    {
        public DbSet<Urunler> UrunTablosu { get; set; }
        public DbSet<Kategori> KategoriTablosu { get; set; }
        public DbSet<Musteri> MusteriTablosu { get; set; }
    }
}
