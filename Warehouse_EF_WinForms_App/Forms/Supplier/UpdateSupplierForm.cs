using System.ComponentModel;
using Warehouse_EF_WinForms_App.Constants;

namespace Warehouse_EF_WinForms_App.Forms.Supplier
{
    public partial class UpdateSupplierForm : Form
    {
        public string SupplierName => txtUpdateSupplierName.Text.Trim();

        public UpdateSupplierForm(string name)
        {
            InitializeComponent();
            txtUpdateSupplierName.Text = name;
        }

        void TxtUpdateSupplierName_Validating(object sender, CancelEventArgs e)
        {
            if (txtUpdateSupplierName.Text.Trim().Length > DatabaseDefaults.StringValueMaxLength)
            {
                nameError.SetError(txtUpdateSupplierName, DatabaseDefaults.NameToLong);
                e.Cancel = true;
            }
            else if (txtUpdateSupplierName.Text.Trim().Length == DatabaseDefaults.StringValueMinLength)
            {
                nameError.SetError(txtUpdateSupplierName, DatabaseDefaults.StringNotEmpty);
                e.Cancel = true;
            }
            else
            {
                nameError.SetError(txtUpdateSupplierName, string.Empty);
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
