using System.ComponentModel;

namespace Warehouse_EF_WinForms_App.Forms.Good
{
    public partial class SetSupplierQueryGoodForm : Form
    {
        public int SupplierId => (int)comboBoxSupplier.SelectedValue!;

        public SetSupplierQueryGoodForm(List<KeyValuePair<string, int>> suppliers)
        {
            InitializeComponent();
            PopulateComboBox(suppliers);
        }

        void PopulateComboBox(List<KeyValuePair<string, int>> suppliers, int supplierId = 0)
        {
            var pairs = new List<KeyValuePair<string, int>>
            {
                new("Не выбран", 0)
            };
            pairs.AddRange(suppliers);

            comboBoxSupplier.DisplayMember = "Key";
            comboBoxSupplier.ValueMember = "Value";
            comboBoxSupplier.DataSource = pairs;
            comboBoxSupplier.SelectedItem = pairs.First(x => x.Value == supplierId);
        }

        void ComboBoxSupplier_Validating(object sender, CancelEventArgs e)
        {
            if ((int)comboBoxSupplier.SelectedValue! == 0)
            {
                errorSupplier.SetError(comboBoxSupplier, "Выберите тип товара");
                e.Cancel = true;
            }
            else
            {
                errorSupplier.SetError(comboBoxSupplier, string.Empty);
                e.Cancel = false;
            }
        }

        void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Text = ((KeyValuePair<string, int>)comboBoxSupplier.SelectedItem).Key;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
