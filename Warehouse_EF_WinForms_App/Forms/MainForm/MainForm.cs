using Warehouse_EF_WinForms_App.Constants;
using Warehouse_EF_WinForms_App.Forms.GoodType;
using Warehouse_EF_WinForms_App.Forms.Supplier;
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
                { 0, LoadGoodsAsync },
                { 1, LoadGoodsTypeAsync },
                { 2, LoadSuppliersAsync },
                { 3, LoadDeliveriesAsync },
            };
        }

        void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTabsMethod[tabControlMain.SelectedIndex]();
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            LoadTabsMethod[0]();
        }

        #region [Load_Database_Table]

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

        #endregion

        #region [Good_Type]

        async void BtnAddGoodType_Click(object sender, EventArgs e)
        {
            var form = new AddGoodTypeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (GoodTypeNameValidating(form.GoodTypeName))
                {
                    await _warehouseService.AddGoodType(form.GoodTypeName);
                    LoadGoodsTypeAsync();
                }
                else
                {
                    MessageBox.Show(DatabaseDefaults.GoodTypeNameAlreadyExists);
                }
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

        async void BtnUpdateGoodType_Click(object sender, EventArgs e)
        {
            if (gridGoodsType.SelectedRows.Count > 0)
            {
                var goodTypeId = int.Parse(gridGoodsType.SelectedRows[0].Cells[0].Value.ToString()!);

                var form = new UpdateGoodTypeForm(_warehouseService.GetNameGoodType(goodTypeId));

                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (GoodTypeNameValidating(form.GoodTypeName))
                    {
                        await _warehouseService.UpdateGoodType(goodTypeId, form.GoodTypeName);
                        LoadGoodsTypeAsync();
                    }
                    else
                    {
                        MessageBox.Show(DatabaseDefaults.GoodTypeNameAlreadyExists);
                    }
                }
            }
        }

        bool GoodTypeNameValidating(string name)
        {
            for (int i = 0; i < gridGoodsType.RowCount; i++)
            {
                var nameInRow = gridGoodsType["Название", i].Value.ToString();
                if (nameInRow == name)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region [Supplier]

        async void BtnAddSupplier_Click(object sender, EventArgs e)
        {
            var form = new AddSupplierForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (SupplierNameValidating(form.SupplierName))
                {
                    await _warehouseService.AddSupplier(form.SupplierName);
                    LoadSuppliersAsync();
                }
                else
                {
                    MessageBox.Show(DatabaseDefaults.SupplierNameAlreadyExists);
                }
            }
        }

        async void BtnDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (gridSuppliers.SelectedRows.Count > 0)
            {
                var supplierId = int.Parse(gridSuppliers.SelectedRows[0].Cells[0].Value.ToString()!);
                try
                {
                    await _warehouseService.DeleteSupplier(supplierId);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoadSuppliersAsync();
                }
            }
            else
            {
                MessageBox.Show(DatabaseDefaults.SelectSupplierToDelete);
            }
        }

        async void BtnUpdateSupplier_Click(object sender, EventArgs e)
        {
            if (gridSuppliers.SelectedRows.Count > 0)
            {
                var supplierId = int.Parse(gridSuppliers.SelectedRows[0].Cells[0].Value.ToString()!);

                var form = new UpdateSupplierForm(_warehouseService.GetNameSupplier(supplierId));

                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (SupplierNameValidating(form.SupplierName))
                    {
                        await _warehouseService.UpdateSupplier(supplierId, form.SupplierName);
                        LoadSuppliersAsync();
                    }
                    else
                    {
                        MessageBox.Show(DatabaseDefaults.SupplierNameAlreadyExists);
                    }
                }
            }
        }

        bool SupplierNameValidating(string name)
        {
            for (int i = 0; i < gridSuppliers.RowCount; i++)
            {
                var nameInRow = gridSuppliers["Название", i].Value.ToString();
                if (nameInRow == name)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion
    }
}