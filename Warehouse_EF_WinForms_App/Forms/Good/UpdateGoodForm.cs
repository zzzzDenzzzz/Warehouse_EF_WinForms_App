using System.ComponentModel;
using Warehouse_EF_WinForms_App.Constants;

namespace Warehouse_EF_WinForms_App.Forms.Good
{
    public partial class UpdateGoodForm : Form
    {
        public string GoodName => txtUpdateGoodName.Text.Trim();
        public decimal GoodCost => numericUpdateGoodCost.Value;
        public int GoodTypeId => (int)comboBoxUpdateGoodType.SelectedValue!;

        public UpdateGoodForm(List<KeyValuePair<string, int>> goodTypes, string name, decimal cost, int goodTypeId)
        {
            InitializeComponent();
            txtUpdateGoodName.Text = name;
            numericUpdateGoodCost.Value = cost;
            PopulateComboBox(goodTypes, goodTypeId);
        }

        void PopulateComboBox(List<KeyValuePair<string, int>> goodTypes, int goodTypeId = 0)
        {
            var pairs = new List<KeyValuePair<string, int>>
            {
                new("Не выбран", 0)
            };
            pairs.AddRange(goodTypes);

            comboBoxUpdateGoodType.DisplayMember = "Key";
            comboBoxUpdateGoodType.ValueMember = "Value";
            comboBoxUpdateGoodType.DataSource = pairs;
            comboBoxUpdateGoodType.SelectedItem = pairs.First(x => x.Value == goodTypeId);
        }

        void TxtUpdateGoodName_Validating(object sender, CancelEventArgs e)
        {
            if (txtUpdateGoodName.Text.Trim().Length > DatabaseDefaults.StringValueMaxLength)
            {
                nameError.SetError(txtUpdateGoodName, DatabaseDefaults.NameToLong);
                e.Cancel = true;
            }
            else if (txtUpdateGoodName.Text.Trim().Length == DatabaseDefaults.StringValueMinLength)
            {
                nameError.SetError(txtUpdateGoodName, DatabaseDefaults.StringNotEmpty);
                e.Cancel = true;
            }
            else
            {
                nameError.SetError(txtUpdateGoodName, string.Empty);
                e.Cancel = false;
            }
        }

        void NumericUpdateGoodCost_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpdateGoodCost.Value == 0)
            {
                errorCost.SetError(numericUpdateGoodCost, "Себестоимость должна быть больше нуля");
                e.Cancel = true;
            }
            else
            {
                errorCost.SetError(numericUpdateGoodCost, string.Empty);
                e.Cancel = false;
            }
        }

        void ComboBoxUpdateGoodType_Validating(object sender, CancelEventArgs e)
        {
            if ((int)comboBoxUpdateGoodType.SelectedValue! == 0)
            {
                errorGoodType.SetError(comboBoxUpdateGoodType, "Выберите тип товара");
                e.Cancel = true;
            }
            else
            {
                errorGoodType.SetError(comboBoxUpdateGoodType, string.Empty);
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
