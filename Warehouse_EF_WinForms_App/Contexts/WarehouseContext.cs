using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Warehouse_EF_WinForms_App.Entities;
using Warehouse_EF_WinForms_App.EntityMappings;

namespace Warehouse_EF_WinForms_App.Contexts;

public partial class WarehouseContext : DbContext
{
    public WarehouseContext()
    {
    }

    public WarehouseContext(DbContextOptions<WarehouseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<Good> Goods { get; set; }

    public virtual DbSet<GoodsType> GoodsType { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
                .UseSqlServer(ConfigurationManager.ConnectionStrings["ConnectionHome"].ConnectionString)
                .UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DeliveryEntityMap).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(GoodEntityMap).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(GoodsTypeEntityMap).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SupplierEntityMap).Assembly);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
