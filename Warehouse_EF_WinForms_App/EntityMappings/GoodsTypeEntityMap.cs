using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse_EF_WinForms_App.Entities;

namespace Warehouse_EF_WinForms_App.EntityMappings
{
    internal class GoodsTypeEntityMap : IEntityTypeConfiguration<GoodsType>
    {
        public void Configure(EntityTypeBuilder<GoodsType> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__GoodsTyp__3214EC07D588955F");

            builder.Property(e => e.Name).HasMaxLength(100);
        }
    }
}
