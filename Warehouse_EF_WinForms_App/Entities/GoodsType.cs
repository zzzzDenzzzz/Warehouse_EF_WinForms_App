namespace Warehouse_EF_WinForms_App.Entities;

public partial class GoodsType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Good> Goods { get; } = new List<Good>();
}
