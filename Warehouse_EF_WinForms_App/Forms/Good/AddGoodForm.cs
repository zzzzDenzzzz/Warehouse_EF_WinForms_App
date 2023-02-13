using System.ComponentModel;
using Warehouse_EF_WinForms_App.Constants;

namespace Warehouse_EF_WinForms_App.Forms.Good
{
    public partial class AddGoodForm : Form
    {
        public string GoodName => txtAddGoodName.Text.Trim();
        public decimal GoodCost => numericGoodCost.Value;
        public int GoodTypeId => (int)comboBoxGoodType.SelectedValue!;

        public AddGoodForm(List<KeyValuePair<string, int>> goodTypes)
        {
            InitializeComponent();
            PopulateComboBox(goodTypes);
        }

        public AddGoodForm(List<KeyValuePair<string, int>> goodTypes, string name, decimal cost, int goodTypeId)
        {
            InitializeComponent();
            Text = "Изменить товар";
            txtAddGoodName.Text = name;
            numericGoodCost.Value = cost;
            PopulateComboBox(goodTypes, goodTypeId);
        }

        void PopulateComboBox(List<KeyValuePair<string, int>> goodTypes, int goodTypeId = 0)
        {
            var pairs = new List<KeyValuePair<string, int>>
            {
                new("Не выбран", 0)
            };
            pairs.AddRange(goodTypes);

            comboBoxGoodType.DisplayMember = "Key";
            comboBoxGoodType.ValueMember = "Value";
            comboBoxGoodType.DataSource = pairs;
            comboBoxGoodType.SelectedItem = pairs.First(x => x.Value == goodTypeId);
        }

        void TxtAddGoodName_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddGoodName.Text.Trim().Length > DatabaseDefaults.StringValueMaxLength)
            {
                nameError.SetError(txtAddGoodName, DatabaseDefaults.NameToLong);
                e.Cancel = true;
            }
            else if (txtAddGoodName.Text.Trim().Length == DatabaseDefaults.StringValueMinLength)
            {
                nameError.SetError(txtAddGoodName, DatabaseDefaults.StringNotEmpty);
                e.Cancel = true;
            }
            else
            {
                nameError.SetError(txtAddGoodName, string.Empty);
                e.Cancel = false;
            }
        }

        void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }

        void NumericGoodCost_Validating(object sender, CancelEventArgs e)
        {
            if (numericGoodCost.Value <= 0)
            {
                errorCost.SetError(numericGoodCost, "Cost > 0");
                e.Cancel = true;
            }
            else
            {
                errorCost.SetError(numericGoodCost, string.Empty);
                e.Cancel = false;
            }
        }

        void ComboBoxGoodType_Validating(object sender, CancelEventArgs e)
        {
            if ((int)comboBoxGoodType.SelectedValue! == 0)
            {
                errorGoodType.SetError(comboBoxGoodType, "Выберите тип товара");
                e.Cancel = true;
            }
            else
            {
                errorGoodType.SetError(comboBoxGoodType, string.Empty);
                e.Cancel = false;
            }
        }
    }
}
