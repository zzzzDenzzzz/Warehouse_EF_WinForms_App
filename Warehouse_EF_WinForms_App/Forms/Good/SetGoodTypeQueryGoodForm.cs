using Castle.Components.DictionaryAdapter.Xml;
using System.ComponentModel;

namespace Warehouse_EF_WinForms_App.Forms.Good
{
    public partial class SetGoodTypeQueryGoodForm : Form
    {
        public int GoodTypeId => (int)comboBoxGoodType.SelectedValue!;

        public SetGoodTypeQueryGoodForm(List<KeyValuePair<string, int>> goodTypes)
        {
            InitializeComponent();
            PopulateComboBox(goodTypes);
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

        void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Text = ((KeyValuePair<string, int>)comboBoxGoodType.SelectedItem).Key;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
