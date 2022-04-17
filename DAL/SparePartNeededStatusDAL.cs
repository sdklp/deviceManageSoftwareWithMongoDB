using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class SparePartNeededStatusDAL : IModel<SparePartNeededStatusModel>
    {
        string collectionName = "SparePartNeededStatus";
        public Task Delete(string id)
        {
            var collection = DBHelper.GetCollection<SparePartNeededStatusModel>(collectionName);
            return collection.DeleteOneAsync(c => c.Id == id);
        }

        public List<SparePartNeededStatusModel> GetAll()
        {
            var collection = DBHelper.GetCollection<SparePartNeededStatusModel>(collectionName);
            return collection.Find(_ => true).ToList();
        }

        public List<SparePartNeededStatusModel> GetDataByFilter(string filterStr)
        {
            throw new NotImplementedException();
        }

        public Task Insert(SparePartNeededStatusModel obj)
        {
            var collection = DBHelper.GetCollection<SparePartNeededStatusModel>(collectionName);
            return collection.InsertOneAsync(obj);
        }

        public Task Update(SparePartNeededStatusModel obj)
        {
            var collection = DBHelper.GetCollection<SparePartNeededStatusModel>(collectionName);
            var filter = Builders<SparePartNeededStatusModel>.Filter.Eq(c => c.Id, obj.Id);
            return collection.ReplaceOneAsync(filter, obj, new ReplaceOptions { IsUpsert = true });
        }
    }
}
