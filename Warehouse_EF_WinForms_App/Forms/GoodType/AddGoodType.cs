using System.ComponentModel;
using Warehouse_EF_WinForms_App.Constants;

namespace Warehouse_EF_WinForms_App.Forms.GoodType
{
    public partial class AddGoodType : Form
    {
        public string GoodTypeName => txtAddGoodTypeName.Text.Trim();

        public AddGoodType()
        {
            InitializeComponent();
        }

        private void TxtAddGoodTypeName_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddGoodTypeName.Text.Trim().Length > DatabaseDefaults.StringValueMaxLength)
            {
                nameError.SetError(txtAddGoodTypeName, "Слишком длинное имя товара");
                e.Cancel = true;
            }
            else
            {
                nameError.SetError(txtAddGoodTypeName, string.Empty);
                e.Cancel = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
