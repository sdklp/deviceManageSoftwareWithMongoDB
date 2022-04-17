using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Models;


namespace DAL
{
    public class DeviceDAL : IModel<DeviceModel>
    {
        string collectionName = "Device";
        public Task Delete(string id)
        {
            var deviceCollection = DBHelper.GetCollection<DeviceModel>(collectionName);           
            return deviceCollection.DeleteOneAsync(c => c.Id == id);
        }

        
        public List<DeviceModel> GetAll()
        {
            var deviceCollection = DBHelper.GetCollection<DeviceModel>(collectionName);
            var results = deviceCollection.Find(_ => true);
            return results.ToList(); 
        }
        public List<DeviceModel> GetDataByFilter(string filterStr)
        {
            var deviceCollection = DBHelper.GetCollection<DeviceModel>(collectionName);
            var filter = Builders<DeviceModel>.Filter.Where(c=>c.DName.ToLower().Contains(filterStr) | c.Location.ToLower().Contains(filterStr));
            var results = deviceCollection.Find(filter);
            return results.ToList();
        }
        public List<DeviceModel> GetDataByFilter(string locationStr,string deviceNoStr)
        {
            var deviceCollection = DBHelper.GetCollection<DeviceModel>(collectionName);
            var filter = Builders<DeviceModel>.Filter.Where(c => c.Location.ToLower().Contains(locationStr) && c.DNo.ToLower().Contains(deviceNoStr));
            var results = deviceCollection.Find(filter);
            return results.ToList();
        }

        public Task Insert(DeviceModel obj)
        {
            var deviceCollection = DBHelper.GetCollection<DeviceModel>(collectionName);
            return deviceCollection.InsertOneAsync(obj);
        }

        public Task Update(DeviceModel obj)
        {
            var deviceCollection = DBHelper.GetCollection<DeviceModel>(collectionName);
            var filter = Builders<DeviceModel>.Filter.Eq("Id",obj.Id);
            return deviceCollection.ReplaceOneAsync(filter, obj, new ReplaceOptions { IsUpsert = true });
        }

        
    }
}
