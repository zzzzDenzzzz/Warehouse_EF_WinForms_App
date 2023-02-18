namespace Warehouse_EF_WinForms_App.Services
{
    public static class MessageBoxService
    {
        public static void Show(string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
