using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MongoDB.Driver;

namespace DAL
{
    class DBHelper
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        private static string databaseName = MongoUrl.Create(connStr).DatabaseName;
        public string GetConnectionString()
        {
            return connStr;
        }
       
        public static IMongoCollection<T> GetCollection<T>(string collectionName)
        {            
            var client = new MongoClient(connStr);
            var db = client.GetDatabase(databaseName);
            return db.GetCollection<T>(collectionName);

        }
    }
}
