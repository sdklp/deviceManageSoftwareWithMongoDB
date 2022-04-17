using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class UnitsDAL : IModel<UnitsModel>
    {
        string collectionName="Units";
        public Task Delete(string id)
        {
            var collection = DBHelper.GetCollection<UnitsModel>(collectionName);
            return collection.DeleteOneAsync(c=>c.Id==id);
        }

        public List<UnitsModel> GetAll()
        {
            var collection = DBHelper.GetCollection<UnitsModel>(collectionName);
            return collection.Find(_ => true).ToList();
        }

        public List<UnitsModel> GetDataByFilter(string filterStr)
        {
            throw new NotImplementedException();
        }

        public Task Insert(UnitsModel obj)
        {
            var collection = DBHelper.GetCollection<UnitsModel>(collectionName);
            return collection.InsertOneAsync(obj);
        }

        public Task Update(UnitsModel obj)
        {
            var collection = DBHelper.GetCollection<UnitsModel>(collectionName);
            var filter = Builders<UnitsModel>.Filter.Eq(c=>c.Id,obj.Id);
            return collection.ReplaceOneAsync(filter, obj, new ReplaceOptions { IsUpsert = true });
        }
    }
}
