using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class MaintenanceDAL : IModel<MaintenanceModel>
    {
        private string collectionName = "Maintenance";
        public Task Delete(string id)
        {
            var collection = DBHelper.GetCollection<MaintenanceModel>(collectionName);           
            return collection.DeleteOneAsync(c=>c.Id==id);
        }

        public List<MaintenanceModel> GetAll()
        {
            var collection = DBHelper.GetCollection<MaintenanceModel>(collectionName);
            return collection.Find(_ => true).ToList() ;
        }

        public List<MaintenanceModel> GetDataByFilter(string filterStr)
        {
            var collection = DBHelper.GetCollection<MaintenanceModel>(collectionName);
            var filter = Builders<MaintenanceModel>.Filter.Where(c => c.PTW.ToLower().Contains(filterStr)| c.DeviceLocation.ToLower().Contains(filterStr)) ;
            return collection.Find(filter).ToList() ;
        }

        public Task Insert(MaintenanceModel obj)
        {
            var collection = DBHelper.GetCollection<MaintenanceModel>(collectionName);
            return collection.InsertOneAsync(obj);
        }

        public Task Update(MaintenanceModel obj)
        {
            var collection = DBHelper.GetCollection<MaintenanceModel>(collectionName);
            var filter = Builders<MaintenanceModel>.Filter.Eq("Id",obj.Id);
            return collection.ReplaceOneAsync(filter,obj,new ReplaceOptions { IsUpsert=true});
        }
    }
}
