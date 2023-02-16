using Warehouse_EF_WinForms_App.Constants;
using Warehouse_EF_WinForms_App.Entities;
using Warehouse_EF_WinForms_App.Forms.Delivery;
using Warehouse_EF_WinForms_App.Forms.Good;
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

        #region [Events]

        void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTabsMethod[tabControlMain.SelectedIndex]();
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            LoadTabsMethod[0]();
        }

        void GridGoods_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnUpdateGood_Click(sender, e);
        }

        void GridGoods_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnUpdateGood_Click(sender, e);
            }
        }

        #endregion

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

        #region [Good_Type Add, Update, Delete]

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
                    MessageBox.Show(DatabaseDefaults.NameAlreadyExists);
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
                MessageBox.Show(DatabaseDefaults.SelectObjectToDelete);
            }
        }

        async void BtnUpdateGoodType_Click(object sender, EventArgs e)
        {
            if (gridGoodsType.SelectedRows.Count > 0)
            {
                var goodTypeId = int.Parse(gridGoodsType.SelectedRows[0].Cells[0].Value.ToString()!);
                var goodType = await _warehouseService.GetGoodTypeById(goodTypeId);

                if (goodType == null)
                {
                    MessageBox.Show("Тип товара не найден");
                    LoadGoodsTypeAsync();
                    return;
                }

                try
                {
                    var form = new UpdateGoodTypeForm(goodType.Name);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (GoodTypeNameValidating(form.GoodTypeName))
                        {
                            await _warehouseService.UpdateGoodType(goodTypeId, form.GoodTypeName);
                        }
                    }
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
        }

        bool GoodTypeNameValidating(string name)
        {
            for (int i = 0; i < gridGoodsType.RowCount; i++)
            {
                var nameInRow = gridGoodsType[DatatableDefault.Name, i].Value.ToString();
                if (nameInRow == name)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region [Supplier Add, Update, Delete]

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
                    MessageBox.Show(DatabaseDefaults.NameAlreadyExists);
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
                MessageBox.Show(DatabaseDefaults.SelectObjectToDelete);
            }
        }

        async void BtnUpdateSupplier_Click(object sender, EventArgs e)
        {
            if (gridSuppliers.SelectedRows.Count > 0)
            {
                var supplierId = int.Parse(gridSuppliers.SelectedRows[0].Cells[0].Value.ToString()!);
                var supplier = await _warehouseService.GetSupplierById(supplierId);

                if (supplier == null)
                {
                    MessageBox.Show("Поставщик не найден");
                    LoadSuppliersAsync();
                    return;
                }

                try
                {
                    var form = new UpdateSupplierForm(supplier.Name);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (SupplierNameValidating(form.SupplierName))
                        {
                            await _warehouseService.UpdateSupplier(supplierId, form.SupplierName);
                        }
                    }
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
        }

        bool SupplierNameValidating(string name)
        {
            for (int i = 0; i < gridSuppliers.RowCount; i++)
            {
                var nameInRow = gridSuppliers[DatatableDefault.Name, i].Value.ToString();
                if (nameInRow == name)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region [Good Add, Update, Delete]

        async void BtnAddGood_Click(object sender, EventArgs e)
        {
            var pairs = await _warehouseService.GetGoodTypesPairs();
            var form = new AddGoodForm(pairs);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await _warehouseService.AddGood(form.GoodName, form.GoodCost, form.GoodTypeId);
                LoadGoodsAsync();
            }
        }

        async void BtnUpdateGood_Click(object sender, EventArgs e)
        {
            if (gridGoods.SelectedRows.Count > 0)
            {
                var goodID = int.Parse(gridGoods.SelectedRows[0].Cells[0].Value.ToString()!);
                var good = await _warehouseService.GetGoodById(goodID);
                if (good == null)
                {
                    MessageBox.Show("Товар не найден");
                    LoadGoodsAsync();
                    return;
                }

                try
                {
                    var pairs = await _warehouseService.GetGoodTypesPairs();
                    var form = new UpdateGoodForm(pairs, good.Name, good.Cost, good.GoodsTypeId);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        await _warehouseService.UpdateGood(good, form.GoodName, form.GoodCost, form.GoodTypeId);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoadGoodsAsync();
                }
            }
            else
            {
                MessageBox.Show("Выберите товар для изменения");
            }
        }

        async void BtnDeleteGood_Click(object sender, EventArgs e)
        {
            if (gridGoods.SelectedRows.Count > 0)
            {
                var goodId = int.Parse(gridGoods.SelectedRows[0].Cells[0].Value.ToString()!);
                try
                {
                    await _warehouseService.DeleteGood(goodId);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoadGoodsAsync();
                }
            }
            else
            {
                MessageBox.Show(DatabaseDefaults.SelectObjectToDelete);
            }
        }

        #endregion

        #region [Delivery Add, Update, Delete]

        async void BtnAddDelivery_Click(object sender, EventArgs e)
        {
            var pairsGood = await _warehouseService.GetGoodPairs();
            var pairsSupplier = await _warehouseService.GetSupplierPairs();
            var form = new AddDeliveryForm(pairsGood, pairsSupplier);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await _warehouseService.AddDelivery(form.Amount, form.DeliveryDate, form.GoodId, form.SupplierId);
                LoadDeliveriesAsync();
            }
        }

        async void BtnUpdateDelivery_Click(object sender, EventArgs e)
        {
            if (gridDeliveries.SelectedRows.Count > 0)
            {
                var deliveryId = int.Parse(gridDeliveries.SelectedRows[0].Cells[0].Value.ToString()!);
                var delivery = await _warehouseService.GetDeliveryById(deliveryId);
                if (delivery == null)
                {
                    MessageBox.Show("Доставка не найдена");
                    LoadDeliveriesAsync();
                    return;
                }

                try
                {
                    var pairsGood = await _warehouseService.GetGoodPairs();
                    var pairsSupplier = await _warehouseService.GetSupplierPairs();
                    var form = new UpdateDeliveryForm(
                        pairsGood, pairsSupplier,
                        delivery.Amount,
                        delivery.GoodsId,
                        delivery.SupplierId,
                        delivery.DeliveryDate);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        await _warehouseService.UpdateDelivery(
                            delivery, form.Amount, form.DeliveryDate, form.GoodId, form.SupplierId);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoadDeliveriesAsync();
                }
            }
            else
            {
                MessageBox.Show("Выберите доставку для изменения");
            }
        }

        async void BtnDeleteDelivery_Click(object sender, EventArgs e)
        {
            if (gridDeliveries.SelectedRows.Count > 0)
            {
                var deliveryId = int.Parse(gridDeliveries.SelectedRows[0].Cells[0].Value.ToString()!);
                try
                {
                    await _warehouseService.DeleteDelivery(deliveryId);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoadDeliveriesAsync();
                }
            }
            else
            {
                MessageBox.Show(DatabaseDefaults.SelectObjectToDelete);
            }
        }

        #endregion

        #region [Queries]

        async void BtnGetGoodMaxAmount_Click(object sender, EventArgs e)
        {
            var good = await _warehouseService.GetGoodMaxAmountAsync();
            MessageBox.Show(good.Name,
                "Товар с максимальным количеством",
                MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }

        async void BtnGetGoodMinAmount_Click(object sender, EventArgs e)
        {
            var good = await _warehouseService.GetGoodMinAmountAsync();
            MessageBox.Show(good.Name,
                "Товар с минимальным количеством",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        async void BtnGetGoodMinCost_Click(object sender, EventArgs e)
        {
            var good = await _warehouseService.GetGoodMinCostAsync();
            MessageBox.Show(good.Name,
                "Товар с минимальной себестоимостью",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        async void BtnGetGoodMaxCost_Click(object sender, EventArgs e)
        {
            var good = await _warehouseService.GetGoodMaxCostAsync();
            MessageBox.Show(good.Name,
                "Товар с максимальной себестоимостью",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        async void BtnGetGoodSetGoodType_Click(object sender, EventArgs e)
        {
            var pairs = await _warehouseService.GetGoodTypesPairs();
            var form = new SetGoodTypeQueryGoodForm(pairs);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var listGood = await _warehouseService.GetGoodSetGoodType(form.GoodTypeId);
                if (listGood != null)
                {
                    string goodSetType = string.Empty;
                    foreach (var item in listGood)
                    {
                        goodSetType += (item.Name + Environment.NewLine);
                    }
                    MessageBox.Show(goodSetType,
                    "Товары, категории" + " - " + form.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        async void BtnGetGoodSetSupplier_Click(object sender, EventArgs e)
        {
            var pairs = await _warehouseService.GetSupplierPairs();
            var form = new SetSupplierQueryGoodForm(pairs);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var listGood = await _warehouseService.GetGoodSetSuplier(form.SupplierId);
                if (listGood != null)
                {
                    string goodSetSupplier = string.Empty;
                    foreach (var item in listGood)
                    {
                        goodSetSupplier += (item.Name + Environment.NewLine);
                    }
                    MessageBox.Show(goodSetSupplier,
                    "Товары, поставщика" + " - " + form.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion

    }
}