using Warehouse_EF_WinForms_App.Constants;
using Warehouse_EF_WinForms_App.Forms.GoodType;
using Warehouse_EF_WinForms_App.Services;

namespace Warehouse_EF_WinForms_App
{
    public partial class MainForm : Form
    {
        readonly WarehouseService _warehouseService;
        readonly Dictionary<int, Action> LoadTabsMethod;

        public MainForm()
        {
            InitializeComponent();
            _warehouseService = new();
            LoadTabsMethod = new()
            {
                { 0, () => LoadGoodsAsync() },
                { 1, () => LoadGoodsTypeAsync() },
                { 2, () => LoadSuppliersAsync() },
                { 3, () => LoadDeliveriesAsync() },
            };
        }

        async void LoadGoodsAsync()
        {
            TableCreatorService.ShowTable(
                gridGoods,
                TableCreatorService.CreateGoodsTable(await _warehouseService.GetGoodsAsync()));
        }

        async void LoadGoodsTypeAsync()
        {
            TableCreatorService.ShowTable(
                gridGoodsType,
                TableCreatorService.CreateGoodsTypeTable(await _warehouseService.GetGoodsTypeAsync()));
        }

        async void LoadSuppliersAsync()
        {
            TableCreatorService.ShowTable(
                gridSuppliers,
                TableCreatorService.CreateSuppliersTable(await _warehouseService.GetSuppliersAsync()));
        }

        async void LoadDeliveriesAsync()
        {
            TableCreatorService.ShowTable(
                gridDeliveries,
                TableCreatorService.CreateDeliveriesTable(await _warehouseService.GetDeliveriesAsync()));
        }

        void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTabsMethod[tabControlMain.SelectedIndex]();
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            LoadTabsMethod[0]();
        }

        async void BtnAddGoodType_Click(object sender, EventArgs e)
        {
            var form = new AddGoodType();
            if (form.ShowDialog() == DialogResult.OK)
            {
                await _warehouseService.AddGoodType(form.GoodTypeName);
                LoadGoodsTypeAsync();
            }
        }

        async void BtnDeleteGoodType_Click(object sender, EventArgs e)
        {
            if (gridGoodsType.SelectedRows.Count > 0)
            {
                var goodTypeId = int.Parse(gridGoodsType.SelectedRows[0].Cells[0].Value.ToString()!);
                try
                {
                    await _warehouseService.DeleteGoodType(goodTypeId);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoadGoodsTypeAsync();
                }
            }
            else
            {
                MessageBox.Show(DatabaseDefaults.SelectGoodTypeToDelete);
            }
        }
    }
}