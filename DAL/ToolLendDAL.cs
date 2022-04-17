using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class ToolLendDAL : IModel<ToolLendModel>
    {
        string collectionName = "ToolLend";
        public Task Delete(string id)
        {
            var collection = DBHelper.GetCollection<ToolLendModel>(collectionName);
            return collection.DeleteOneAsync(c=>c.Id==id);
        }

        public List<ToolLendModel> GetAll()
        {
            var collection = DBHelper.GetCollection<ToolLendModel>(collectionName);
            return collection.Find(_ => true).ToList();
        }
       
        public List<ToolLendModel> GetDataByFilter(string filterStr)
        {
            var collection = DBHelper.GetCollection<ToolLendModel>(collectionName);
            var filter = Builders<ToolLendModel>.Filter.Where(c=>c.ToolName.ToLower().Contains(filterStr))| Builders<ToolLendModel>.Filter.Where(c => c.LendPerson.ToLower().Contains(filterStr));
            return collection.Find(filter).ToList();
        }
        
        public List<ToolLendModel> GetDataByFilterNotFinish(string filterStr)
        {
            var collection = DBHelper.GetCollection<ToolLendModel>(collectionName);
            var filter = (Builders<ToolLendModel>.Filter.Where(c => c.ToolName.ToLower().Contains(filterStr)) | Builders<ToolLendModel>.Filter.Where(c => c.LendPerson.ToLower().Contains(filterStr)))&Builders<ToolLendModel>.Filter.Where(c=>c.DiffQty!=0);
            return collection.Find(filter).ToList();
        }
        public List<ToolLendModel> GetDataByToolId(string filterStr)
        {
            var collection = DBHelper.GetCollection<ToolLendModel>(collectionName);
            var filter = Builders<ToolLendModel>.Filter.Eq(c => c.ToolId, filterStr);
            return collection.Find(filter).ToList();
        }
        public List<ToolLendModel> GetDataByToolIdNotFinish(string filterStr)
        {
            var collection = DBHelper.GetCollection<ToolLendModel>(collectionName);
            var filter = Builders<ToolLendModel>.Filter.Eq(c => c.ToolId, filterStr) & Builders<ToolLendModel>.Filter.Where(c => c.DiffQty!= 0);
            return collection.Find(filter).ToList();
        }
        public Task Insert(ToolLendModel obj)
        {
            var collection = DBHelper.GetCollection<ToolLendModel>(collectionName);
            return collection.InsertOneAsync(obj);
        }

        public Task Update(ToolLendModel obj)
        {
            var collection = DBHelper.GetCollection<ToolLendModel>(collectionName);
            var filter = Builders<ToolLendModel>.Filter.Eq(c=>c.Id,obj.Id);
            return collection.ReplaceOneAsync(filter,obj,new ReplaceOptions { IsUpsert = true });
        }
    }
}
