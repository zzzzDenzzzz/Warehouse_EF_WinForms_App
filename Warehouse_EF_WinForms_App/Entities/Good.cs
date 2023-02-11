namespace Warehouse_EF_WinForms_App.Entities;

public partial class Good
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int GoodsTypeId { get; set; }

    public decimal Cost { get; set; }

    public virtual ICollection<Delivery> Deliveries { get; } = new List<Delivery>();

    public virtual GoodsType GoodsType { get; set; } = null!;
}
