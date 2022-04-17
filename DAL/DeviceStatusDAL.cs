using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class DeviceStatusDAL : IModel<DeviceStatusModel>
    {
        string collectionName = "DeviceStatus";
        public Task Delete(string id)
        {
            var collection = DBHelper.GetCollection<DeviceStatusModel>(collectionName);
            return collection.DeleteOneAsync(c=>c.Id==id);
        }

        public List<DeviceStatusModel> GetAll()
        {
            var collection = DBHelper.GetCollection<DeviceStatusModel>(collectionName);
            return collection.Find(_ => true).ToList() ;
        }

        public List<DeviceStatusModel> GetDataByFilter(string filterStr)
        {
            throw new NotImplementedException();
        }

        public Task Insert(DeviceStatusModel obj)
        {
            var collection = DBHelper.GetCollection<DeviceStatusModel>(collectionName);
            return collection.InsertOneAsync(obj);
        }

        public Task Update(DeviceStatusModel obj)
        {
            var collection = DBHelper.GetCollection<DeviceStatusModel>(collectionName);
            var filter = Builders<DeviceStatusModel>.Filter.Eq(c=>c.Id,obj.Id);
            return collection.ReplaceOneAsync(filter,obj,new ReplaceOptions { IsUpsert = true });
        }
    }
}
