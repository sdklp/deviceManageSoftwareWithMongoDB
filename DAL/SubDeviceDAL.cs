using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class SubDeviceDAL : IModel<SubDeviceModel>
    {
        string collectionName = "SubDevice";
        public Task Delete(string id)
        {
            var collection = DBHelper.GetCollection<SubDeviceModel>(collectionName);
            return collection.DeleteOneAsync(c=>c.Id==id);
        }

        public List<SubDeviceModel> GetAll()
        {
            var collection = DBHelper.GetCollection<SubDeviceModel>(collectionName);
            return collection.Find(_ => true).ToList() ;
        }

        public List<SubDeviceModel> GetDataByFilter(string filterStr)
        {
            var collection = DBHelper.GetCollection<SubDeviceModel>(collectionName);
            var filter = Builders<SubDeviceModel>.Filter.Where(c=>c.SubDevice.ToLower().Contains(filterStr));
            return collection.Find(filter).ToList() ;
        }
        public List<SubDeviceModel> GetDataByPid(string filterStr)
        {
            var collection = DBHelper.GetCollection<SubDeviceModel>(collectionName);
            var filter = Builders<SubDeviceModel>.Filter.Eq(c => c.Pid, filterStr);
            return collection.Find(filter).ToList();
        }
        public List<SubDeviceModel> GetDataById(string filterStr)
        {
            var collection = DBHelper.GetCollection<SubDeviceModel>(collectionName);
            var filter = Builders<SubDeviceModel>.Filter.Eq(c => c.Id, filterStr);
            return collection.Find(filter).ToList();
        }
        public List<SubDeviceModel> GetDataBySubDeviceName(string filterStr)
        {
            var collection = DBHelper.GetCollection<SubDeviceModel>(collectionName);
            var filter = Builders<SubDeviceModel>.Filter.Where(c => c.SubDevice.ToLower().Contains(filterStr));
            return collection.Find(filter).ToList();
        }
        public Task Insert(SubDeviceModel obj)
        {
            var collection = DBHelper.GetCollection<SubDeviceModel>(collectionName);
            return collection.InsertOneAsync(obj);
        }

        public Task Update(SubDeviceModel obj)
        {
            var collection = DBHelper.GetCollection<SubDeviceModel>(collectionName);
            var filter = Builders<SubDeviceModel>.Filter.Eq(c => c.Id, obj.Id);
            return collection.ReplaceOneAsync(filter,obj,new ReplaceOptions { IsUpsert = true });
        }
    }
}
