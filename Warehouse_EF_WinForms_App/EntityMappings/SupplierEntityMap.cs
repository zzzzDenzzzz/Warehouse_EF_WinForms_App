using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse_EF_WinForms_App.Entities;

namespace Warehouse_EF_WinForms_App.EntityMappings
{
    internal class SupplierEntityMap : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Supplier__3214EC079DF34C90");

            builder.Property(e => e.Name).HasMaxLength(100);
        }
    }
}
