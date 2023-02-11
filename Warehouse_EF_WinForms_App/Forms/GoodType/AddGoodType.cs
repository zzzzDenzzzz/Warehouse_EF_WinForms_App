namespace Warehouse_EF_WinForms_App.Forms.GoodType
{
    public partial class AddGoodType : Form
    {
        public string GoodTypeName => txtAddGoodTypeName.Text.Trim();

        public AddGoodType()
        {
            InitializeComponent();
        }
    }
}
