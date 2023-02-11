namespace Warehouse_EF_WinForms_App.Entities;

public partial class Delivery
{
    public int Id { get; set; }

    public int Amount { get; set; }

    public DateTime DeliveryDate { get; set; }

    public int GoodsId { get; set; }

    public int SupplierId { get; set; }

    public virtual Good Goods { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
