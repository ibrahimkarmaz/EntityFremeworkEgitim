using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using OrnekEF2.Entities;

namespace OrnekEF2.Mappings
{
    public class CustomerMap:EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            this.HasKey(x => x.CustomerID);
            this.Property(x => x.CustomerID).IsRequired().HasMaxLength(5);

            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(40).IsUnicode();

            this.Property(c => c.City).HasMaxLength(15);

            this.Property(y => y.ContactName).HasMaxLength(30);

            this.Property(y => y.Country).HasMaxLength(15);

            this.ToTable("Customers");

            

            //Kullanılması zorunlu değil fakat kullanılması iyi olacaktır.
            //Özellikler ile Column vb yapıları ayır.
            //Okunurluk için
            //Yapılabilecek hatalardan korur.

            this.Property(y => y.CustomerID).HasColumnName("CustomerID");
            this.Property(y => y.Country).HasColumnName("Country");
            this.Property(y => y.ContactName).HasColumnName("ContactName");
            this.Property(y => y.CompanyName).HasColumnName("CustomerIDCompanyName");
            this.Property(y => y.City).HasColumnName("City");



        }
    }
}
