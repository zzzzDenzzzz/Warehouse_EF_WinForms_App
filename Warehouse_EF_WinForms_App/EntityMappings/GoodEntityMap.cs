using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse_EF_WinForms_App.Entities;

namespace Warehouse_EF_WinForms_App.EntityMappings
{
    internal class GoodEntityMap : IEntityTypeConfiguration<Good>
    {
        public void Configure(EntityTypeBuilder<Good> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Goods__3214EC07A3278453");

            builder.HasIndex(e => e.GoodsTypeId, "IX_Goods_GoodsTypeId");

            builder.Property(e => e.Cost).HasColumnType("money");
            builder.Property(e => e.Name).HasMaxLength(100);

            builder.HasOne(d => d.GoodsType).WithMany(p => p.Goods)
                .HasForeignKey(d => d.GoodsTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Goods__GoodsType__286302EC");
        }
    }
}
