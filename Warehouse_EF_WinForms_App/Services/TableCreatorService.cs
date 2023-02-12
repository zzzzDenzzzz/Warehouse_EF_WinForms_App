using System.Data;
using Warehouse_EF_WinForms_App.Constants;
using Warehouse_EF_WinForms_App.Entities;

namespace Warehouse_EF_WinForms_App.Services
{
    internal class TableCreatorService
    {
        public static DataTable CreateGoodsTable(List<Good> goods)
        {
            DataTable table = new();
            table.Clear();
            table.Columns.Add(DatatableDefault.Id);
            table.Columns.Add(DatatableDefault.Name);
            table.Columns.Add(DatatableDefault.Cost);
            table.Columns.Add(DatatableDefault.GoodType);

            foreach (var good in goods)
            {
                DataRow row = table.NewRow();
                row[0] = good.Id;
                row[1] = good.Name;
                row[2] = good.Cost;
                row[3] = good.GoodsType.Name;
                table.Rows.Add(row);
            }

            return table;
        }

        public static DataTable CreateGoodsTypeTable(List<GoodsType> goodsType)
        {
            DataTable table = new();
            table.Clear();
            table.Columns.Add(DatatableDefault.Id);
            table.Columns.Add(DatatableDefault.Name);

            foreach (var goodType in goodsType)
            {
                DataRow row = table.NewRow();
                row[0] = goodType.Id;
                row[1] = goodType.Name;
                table.Rows.Add(row);
            }

            return table;
        }

        public static DataTable CreateDeliveriesTable(List<Delivery> deliveries)
        {
            DataTable table = new();
            table.Clear();
            table.Columns.Add(DatatableDefault.Id);
            table.Columns.Add(DatatableDefault.Amount);
            table.Columns.Add(DatatableDefault.DeliveryDate);
            table.Columns.Add(DatatableDefault.Good);
            table.Columns.Add(DatatableDefault.Supplier);

            foreach (var delivery in deliveries)
            {
                DataRow row = table.NewRow();
                row[0] = delivery.Id;
                row[1] = delivery.Amount;
                row[2] = delivery.DeliveryDate;
                row[3] = delivery.Goods.Name;
                row[4] = delivery.Supplier.Name;
                table.Rows.Add(row);
            }

            return table;
        }

        public static DataTable CreateSuppliersTable(List<Supplier> suppliers)
        {
            DataTable table = new();
            table.Clear();
            table.Columns.Add(DatatableDefault.Id);
            table.Columns.Add(DatatableDefault.Name);

            foreach (var supplier in suppliers)
            {
                DataRow row = table.NewRow();
                row[0] = supplier.Id;
                row[1] = supplier.Name;
                table.Rows.Add(row);
            }

            return table;
        }

        public static void ShowTable(DataGridView grid, DataTable table)
        {
            grid.DataSource = null;
            grid.DataSource = table;
            grid.Columns[0].Visible = false;
        }
    }
}
