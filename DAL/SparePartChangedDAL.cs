using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class SparePartChangedDAL : IModel<SparePartChangedModel>
    {
        public Task Delete(string id)
        {
            var collection = DBHelper.GetCollection<SparePartChangedModel>(collectionName);
            return collection.DeleteOneAsync(c=>c.ID==id);
        }
        string collectionName = "SparePartChanged";
        public List<SparePartChangedModel> GetAll()
        {
            var collection = DBHelper.GetCollection<SparePartChangedModel>(collectionName);
            return collection.Find(_ => true).ToList() ;
        }

        public List<SparePartChangedModel> GetDataByFilter(string filterStr)
        {
            var collection = DBHelper.GetCollection<SparePartChangedModel>(collectionName);
            var filter = Builders<SparePartChangedModel>.Filter.Where(c=>c.DeviceLocation.ToLower().Contains(filterStr));
            return collection.Find(filter).ToList() ;
        }

        public Task Insert(SparePartChangedModel obj)
        {
            var collection = DBHelper.GetCollection<SparePartChangedModel>(collectionName);
            return collection.InsertOneAsync(obj) ;
        }

        public Task Update(SparePartChangedModel obj)
        {
            var collection = DBHelper.GetCollection<SparePartChangedModel>(collectionName);
            var filter = Builders<SparePartChangedModel>.Filter.Eq(c=>c.ID,obj.ID);
            return collection.ReplaceOneAsync(filter,obj,new ReplaceOptions { IsUpsert=true});
        }
    }
}
