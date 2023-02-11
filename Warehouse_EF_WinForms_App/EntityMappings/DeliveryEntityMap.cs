using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse_EF_WinForms_App.Entities;

namespace Warehouse_EF_WinForms_App.EntityMappings
{
    internal class DeliveryEntityMap : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.HasKey(e => e.Id)
                .HasName("PK__Deliveri__3214EC075FADAC59");

            builder.HasIndex(e => e.GoodsId, "IX_Deliveries_GoodsId");

            builder.HasIndex(e => e.SupplierId, "IX_Deliveries_SupplierId");

            builder.HasOne(d => d.Goods)
                .WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.GoodsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Deliverie__Goods__2B3F6F97");

            builder.HasOne(d => d.Supplier).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Deliverie__Suppl__2C3393D0");
        }
    }
}
