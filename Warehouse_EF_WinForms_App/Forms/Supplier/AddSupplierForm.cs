using System.ComponentModel;
using Warehouse_EF_WinForms_App.Constants;

namespace Warehouse_EF_WinForms_App.Forms.Supplier
{
    public partial class AddSupplierForm : Form
    {
        public string SupplierName => txtAddSupplierName.Text.Trim();

        public AddSupplierForm()
        {
            InitializeComponent();
        }

        void TxtAddSupplierName_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddSupplierName.Text.Trim().Length > DatabaseDefaults.StringValueMaxLength)
            {
                nameError.SetError(txtAddSupplierName, DatabaseDefaults.NameToLong);
                e.Cancel = true;
            }
            else if (txtAddSupplierName.Text.Trim().Length == DatabaseDefaults.StringValueMinLength)
            {
                nameError.SetError(txtAddSupplierName, DatabaseDefaults.StringNotEmpty);
                e.Cancel = true;
            }
            else
            {
                nameError.SetError(txtAddSupplierName, string.Empty);
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
