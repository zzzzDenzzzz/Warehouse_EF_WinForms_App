namespace Warehouse_EF_WinForms_App.Entities;

public partial class Supplier
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Delivery> Deliveries { get; } = new List<Delivery>();
}
