using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class AddressDAL : IModel<AddressModel>
    {
        string collectionName = "Address";
        public Task Delete(string id)
        {
            var collection = DBHelper.GetCollection<AddressModel>(collectionName);
            return collection.DeleteOneAsync(c=>c.Id==id);
        }

        public List<AddressModel> GetAll()
        {
            throw new NotImplementedException();
        }
        public List<AddressModel> GetDataById(string filterStr)
        {
            var collection = DBHelper.GetCollection<AddressModel>(collectionName);
            var filter = Builders<AddressModel>.Filter.Eq(c => c.Id, filterStr);
            return collection.Find(filter).ToList();
        }
        public List<AddressModel> GetDataByPid(string filterStr)
        {
            var collection = DBHelper.GetCollection<AddressModel>(collectionName);
            var filter = Builders<AddressModel>.Filter.Eq(c => c.Pid, filterStr);
            return collection.Find(filter).ToList();
        }
        public List<AddressModel> GetDataByName(string filterStr)
        {
            var collection = DBHelper.GetCollection<AddressModel>(collectionName);
            var filter = Builders<AddressModel>.Filter.Eq(c => c.Name, filterStr);
            return collection.Find(filter).ToList();
        }
        public List<AddressModel> GetDataOfProvince(string filterStr)
        {
            throw new NotImplementedException();
        }
        public List<AddressModel> GetDataOfCity(string filterStr)
        {
            throw new NotImplementedException();
        }
        public Task Insert(AddressModel obj)
        {
            var collection = DBHelper.GetCollection<AddressModel>(collectionName);
            return collection.InsertOneAsync(obj);
        }

        public Task Update(AddressModel obj)
        {
            var collection = DBHelper.GetCollection<AddressModel>(collectionName);
            var filter = Builders<AddressModel>.Filter.Eq(c=>c.Id,obj.Id);
            return collection.ReplaceOneAsync(filter,obj,new ReplaceOptions { IsUpsert = true });
        }

        public List<AddressModel> GetDataByFilter(string filterStr)
        {
            throw new NotImplementedException();
        }
    }
}
