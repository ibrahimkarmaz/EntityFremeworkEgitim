using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using OrnekEF2.Entities;

namespace OrnekEF2.Mappings
{
    public class OrderMap:EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            this.HasKey(x => x.OrderID);
            this.Property(y => y.CustomerID).IsFixedLength().HasMaxLength(5);

            this.ToTable("Orders");

            this.Property(y => y.OrderID).HasParameterName("OrderID");
            this.Property(y => y.CustomerID).HasParameterName("CustomerID");
            this.Property(y => y.OrderDate).HasParameterName("OrderDate");


            this.HasOptional(y => y.Customer).WithMany(t => t.Orders).HasForeignKey(x => x.CustomerID);
        }
    }
}
