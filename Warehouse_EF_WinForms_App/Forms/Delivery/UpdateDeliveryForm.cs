using System.ComponentModel;

namespace Warehouse_EF_WinForms_App.Forms.Delivery
{
    public partial class UpdateDeliveryForm : Form
    {
        public int Amount => (int)numericAmount.Value;
        public int GoodId => (int)comboBoxGood.SelectedValue!;
        public int SupplierId => (int)comboBoxSupplier.SelectedValue!;
        public DateTime DeliveryDate => dateTimePickerDelivery.Value;

        public UpdateDeliveryForm(
            List<KeyValuePair<string, int>> good,
            List<KeyValuePair<string, int>> supplier,
            int amount, int goodId, int supplierId, DateTime date)
        {
            InitializeComponent();
            numericAmount.Value = amount;
            PopulateComboBoxGood(good, goodId);
            PopulateComboBoxSupplier(supplier, supplierId);
            dateTimePickerDelivery.Value = date;
        }

        void PopulateComboBoxGood(List<KeyValuePair<string, int>> good, int goodId = 0)
        {
            var pairs = new List<KeyValuePair<string, int>>
            {
                new("Не выбран", 0)
            };
            pairs.AddRange(good);

            comboBoxGood.DisplayMember = "Key";
            comboBoxGood.ValueMember = "Value";
            comboBoxGood.DataSource = pairs;
            comboBoxGood.SelectedItem = pairs.First(x => x.Value == goodId);
        }

        void PopulateComboBoxSupplier(List<KeyValuePair<string, int>> supplier, int supplierId = 0)
        {
            var pairs = new List<KeyValuePair<string, int>>
            {
                new("Не выбран", 0)
            };
            pairs.AddRange(supplier);

            comboBoxSupplier.DisplayMember = "Key";
            comboBoxSupplier.ValueMember = "Value";
            comboBoxSupplier.DataSource = pairs;
            comboBoxSupplier.SelectedItem = pairs.First(x => x.Value == supplierId);
        }

        void NumericAmount_Validating(object sender, CancelEventArgs e)
        {
            if (numericAmount.Value == 0)
            {
                errorAmount.SetError(numericAmount, "Количество должно быть больше нуля");
                e.Cancel = true;
            }
            else
            {
                errorAmount.SetError(numericAmount, string.Empty);
                e.Cancel = false;
            }
        }

        void ComboBoxGood_Validating(object sender, CancelEventArgs e)
        {
            if ((int)comboBoxGood.SelectedValue! == 0)
            {
                errorGood.SetError(comboBoxGood, "Выберите товар");
                e.Cancel = true;
            }
            else
            {
                errorGood.SetError(comboBoxGood, string.Empty);
                e.Cancel = false;
            }
        }

        void ComboBoxSupplier_Validating(object sender, CancelEventArgs e)
        {
            if ((int)comboBoxGood.SelectedValue! == 0)
            {
                errorSupplier.SetError(comboBoxSupplier, "Выберите поставщика");
                e.Cancel = true;
            }
            else
            {
                errorSupplier.SetError(comboBoxSupplier, string.Empty);
                e.Cancel = false;
            }
        }

        void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
