namespace Warehouse_EF_WinForms_App.Constants
{
    public class DatabaseDefaults
    {
        public static readonly int StringValueMaxLength = 100;
        public static readonly int StringValueMinLength = 0;
        public static readonly string GoodsTypeDelitionIsNotPossible = "В системе существуют товары с таким типом. Удаление невозможно";
        public static readonly string GoodTypeNotExist = "Такого типа товара не существует";
        public static readonly string SelectGoodTypeToDelete = "Выберите тип товара для удаления!";
        public static readonly string GoodTypeNameToLong = "Слишком длинное имя типа товара";
        public static readonly string StringNotEmpty = "Строка не может быть пустой!";
        public static readonly string GoodTypeNameAlreadyExists = "Название типа товара уже существует";
    }
}
