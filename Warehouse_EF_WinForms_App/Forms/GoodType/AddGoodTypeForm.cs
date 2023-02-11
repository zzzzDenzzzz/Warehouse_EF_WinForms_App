using System.ComponentModel;
using Warehouse_EF_WinForms_App.Constants;

namespace Warehouse_EF_WinForms_App.Forms.GoodType
{
    public partial class AddGoodTypeForm : Form
    {
        public string GoodTypeName => txtAddGoodTypeName.Text.Trim();

        public AddGoodTypeForm()
        {
            InitializeComponent();
        }

        void TxtAddGoodTypeName_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddGoodTypeName.Text.Trim().Length > DatabaseDefaults.StringValueMaxLength)
            {
                nameError.SetError(txtAddGoodTypeName, DatabaseDefaults.GoodTypeNameToLong);
                e.Cancel = true;
            }
            else if (txtAddGoodTypeName.Text.Trim().Length == DatabaseDefaults.StringValueMinLength)
            {
                nameError.SetError(txtAddGoodTypeName, DatabaseDefaults.StringNotEmpty);
                e.Cancel = true;
            }
            else
            {
                nameError.SetError(txtAddGoodTypeName, string.Empty);
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
