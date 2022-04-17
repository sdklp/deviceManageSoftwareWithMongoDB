using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;


namespace DAL
{
    public class LocationDAL : IModel<LocationModel>
    {
        string collectionName="Location";
        public Task Delete(string id)
        {
            var collection = DBHelper.GetCollection<LocationModel>(collectionName);
            return collection.DeleteOneAsync(c=>c.Id==id);
        }

        public List<LocationModel> GetAll()
        {
            var collection = DBHelper.GetCollection<LocationModel>(collectionName);
            return collection.Find(_ => true).ToList() ;
        }

        public List<LocationModel> GetDataByFilter(string filterStr)
        {
            var collection = DBHelper.GetCollection<LocationModel>(collectionName);
            var filter = Builders<LocationModel>.Filter.Where(c=>c.LName.ToLower().Contains(filterStr));
            return collection.Find(filter).ToList() ;
        }
        public List<LocationModel> GetDataByLocationName(string filterStr)
        {
            var collection = DBHelper.GetCollection<LocationModel>(collectionName);
            var filter = Builders<LocationModel>.Filter.Where(c => c.LName.ToLower().Contains(filterStr));
            return collection.Find(filter).ToList();
        }
        public List<LocationModel> GetDataById(string id)
        {
            var collection = DBHelper.GetCollection<LocationModel>(collectionName);
            var filter = Builders<LocationModel>.Filter.Eq(c => c.Id, id);
            return collection.Find(filter).ToList();
        }
        public List<LocationModel> GetDataByPid(string pid)
        {
            var collection = DBHelper.GetCollection<LocationModel>(collectionName);
            var filter = Builders<LocationModel>.Filter.Eq(c=>c.Pid,pid);
            return collection.Find(filter).ToList() ;
        }
        public Task Insert(LocationModel obj)
        {
            var collection = DBHelper.GetCollection<LocationModel>(collectionName);
            return collection.InsertOneAsync(obj);
        }

        public Task Update(LocationModel obj)
        {
            var collection = DBHelper.GetCollection<LocationModel>(collectionName);
            var filter = Builders<LocationModel>.Filter.Eq(c=>c.Id,obj.Id);
            return collection.ReplaceOneAsync(filter,obj,new ReplaceOptions { IsUpsert=true});
        }
    }
}
