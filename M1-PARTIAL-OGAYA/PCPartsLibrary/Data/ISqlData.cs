namespace PCPartsLibrary.Data
{
    public interface ISqlData
    {
        void Build(string tableName);
        void CreateData(string tableName, string name, string code, string brand, decimal unitPrice);
        void DeleteData(string tableName, int id);
        IEnumerable<dynamic> ReadData(string tableName, string search = null, string brand = null, decimal? minPrice = null, decimal? maxPrice = null);
        void UpdateData(string tableName, int id, string name, string code, string brand, decimal unitPrice);
    }
}