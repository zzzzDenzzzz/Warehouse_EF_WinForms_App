namespace Warehouse_EF_WinForms_App.Forms.Good
{
    public partial class SetDateDeliveryQueryGoodForm : Form
    {
        public int Days => (int)numericAmountDays.Value;

        public SetDateDeliveryQueryGoodForm()
        {
            InitializeComponent();
        }

        void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
