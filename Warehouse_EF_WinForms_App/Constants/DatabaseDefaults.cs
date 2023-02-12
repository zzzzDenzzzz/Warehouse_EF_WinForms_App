namespace Warehouse_EF_WinForms_App.Constants
{
    public class DatabaseDefaults
    {
        public static readonly int StringValueMaxLength = 100;
        public static readonly int StringValueMinLength = 0;
        public static readonly string GoodsTypeDelitionIsNotPossible = "В системе существуют товары с таким типом. Удаление невозможно";
        public static readonly string DeliveriesDelitionIsNotPossible = "В системе существуют достаки данного поставщика. Удаление невозможно";
        public static readonly string ObjectNotExist = "Такого обЪекта не существует";
        public static readonly string SelectObjectToDelete = "Выберите обЪект для удаления!";
        public static readonly string NameToLong = "Слишком длинное имя";
        public static readonly string StringNotEmpty = "Строка не может быть пустой!";
        public static readonly string GoodTypeNameAlreadyExists = "Название типа товара уже существует";
        public static readonly string SupplierNameAlreadyExists = "Название поставщика уже существует";
    }
}
