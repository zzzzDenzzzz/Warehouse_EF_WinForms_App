using System.ComponentModel;
using Warehouse_EF_WinForms_App.Constants;

namespace Warehouse_EF_WinForms_App.Forms.GoodType
{
    public partial class UpdateGoodTypeForm : Form
    {
        public string GoodTypeName => txtUpdateGoodTypeName.Text.Trim();

        public UpdateGoodTypeForm(string name)
        {
            InitializeComponent();
            txtUpdateGoodTypeName.Text = name;
        }

        void TxtUpdateGoodTypeName_Validating(object sender, CancelEventArgs e)
        {
            if (txtUpdateGoodTypeName.Text.Trim().Length > DatabaseDefaults.StringValueMaxLength)
            {
                nameError.SetError(txtUpdateGoodTypeName, DatabaseDefaults.NameToLong);
                e.Cancel = true;
            }
            else if (txtUpdateGoodTypeName.Text.Trim().Length == DatabaseDefaults.StringValueMinLength)
            {
                nameError.SetError(txtUpdateGoodTypeName, DatabaseDefaults.StringNotEmpty);
                e.Cancel = true;
            }
            else
            {
                nameError.SetError(txtUpdateGoodTypeName, string.Empty);
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
