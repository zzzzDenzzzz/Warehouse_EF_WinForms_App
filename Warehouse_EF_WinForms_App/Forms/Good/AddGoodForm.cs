using System.ComponentModel;
using Warehouse_EF_WinForms_App.Constants;

namespace Warehouse_EF_WinForms_App.Forms.Good
{
    public partial class AddGoodForm : Form
    {
        public string GoodName => txtAddGoodName.Text.Trim();
        public decimal GoodCost => numericGoodCost.Value;
        public int GoodType => int.Parse(comboBoxGoodType.Text);

        public AddGoodForm()
        {
            InitializeComponent();
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
    }
}
