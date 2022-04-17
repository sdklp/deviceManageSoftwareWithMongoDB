using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Models;

namespace DAL
{
    public class DevicePartDAL : IModel<DevicePartModel>
    {
        string collectionName = "DevicePart";
        
        public Task Delete(string id)
        {
            var dpCollection = DBHelper.GetCollection<DevicePartModel>(collectionName);
            
            return dpCollection.DeleteOneAsync(c=>c.Id==id);
        }

        public List<DevicePartModel> GetAll()
        {
            var dpCollection = DBHelper.GetCollection<DevicePartModel>(collectionName);
            return dpCollection.Find(_ => true).ToList();
        }

        public List<DevicePartModel> GetDataByFilter(string filterStr)
        {
            var dpCollection = DBHelper.GetCollection<DevicePartModel>(collectionName);
            var filter = Builders<DevicePartModel>.Filter.Where(c=>c.Location.ToLower().Contains(filterStr) |c.PName.ToLower().Contains(filterStr));
            return dpCollection.Find(filter).ToList(); 
        }

        public Task Insert(DevicePartModel obj)
        {
            var dpCollection = DBHelper.GetCollection<DevicePartModel>(collectionName);
            return dpCollection.InsertOneAsync(obj);

        }

        public Task Update(DevicePartModel obj)
        {
            var dpCollection = DBHelper.GetCollection<DevicePartModel>(collectionName);
            var filter = Builders<DevicePartModel>.Filter.Eq("Id",obj.Id);
            return dpCollection.ReplaceOneAsync(filter, obj, new ReplaceOptions { IsUpsert = true });
        }
    }
}
