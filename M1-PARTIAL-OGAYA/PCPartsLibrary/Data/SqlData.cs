using Microsoft.Extensions.Configuration;
using PCPartsLibrary.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCPartsLibrary.Data
{
    public class SqlData : ISqlData
    {
        private ISqlDataAccess _db;
        private const string connectionStringName = "SqlDb";

        public SqlData(ISqlDataAccess db)
        {
            _db = db;
        }
        public void CreateData(string tableName, string name, string code, string brand, decimal unitPrice)
        {
            _db.SaveData<dynamic>(
                "dbo.spParts_CreateData",
                new { tableName, name, code, brand, unitPrice },
                connectionStringName,
                true);
        }

        public IEnumerable<dynamic> ReadData(string tableName, 
            string search = null, 
            string brand = null, 
            decimal? minPrice = null, 
            decimal? maxPrice = null)
        {
            var parameters = new
            {
                TableName = tableName,
                SearchString = string.IsNullOrEmpty(search) ? (object)DBNull.Value : search.ToLower(),
                Brand = string.IsNullOrEmpty(brand) ? (object)DBNull.Value : brand.ToLower(),
                MinPrice = minPrice.HasValue ? minPrice.Value : (object)DBNull.Value,
                MaxPrice = maxPrice.HasValue ? maxPrice.Value : (object)DBNull.Value
            };

            var result = _db.LoadData<dynamic, dynamic>(
                "dbo.spParts_ReadData",
                parameters,
                connectionStringName,
                true
            );

            return result;
        }

        public void UpdateData(string tableName, 
            int id, string name, 
            string code, 
            string brand, 
            decimal unitPrice)
        {
            _db.SaveData(
                "dbo.spParts_UpdateData",
                new { tableName, id, name, code, brand, unitPrice },
                connectionStringName,
                true);
        }

        public void DeleteData(string tableName, int id)
        {
            _db.SaveData(
                "dbo.spParts_DeleteData",
                new { tableName, id },
                connectionStringName,
                true);
        }

        public void Build(string tableName)
        {
            _db.SaveData<dynamic>(
                "dbo.spParts_Build",
                new { tableName },
                connectionStringName,
                true);
        }


    }
}
