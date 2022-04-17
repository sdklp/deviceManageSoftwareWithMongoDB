using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class ToolDAL : IModel<ToolModel>
    {
        string collectionName = "Tools";
        public Task Delete(string id)
        {
            var collection = DBHelper.GetCollection<ToolModel>(collectionName);
            return collection.DeleteOneAsync(c=>c.Id==id);
        }

        public List<ToolModel> GetAll()
        {
            var collection = DBHelper.GetCollection<ToolModel>(collectionName);
            return collection.Find(_ => true).ToList();
        }

        public List<ToolModel> GetDataByFilter(string filterStr)
        {
            var collection = DBHelper.GetCollection<ToolModel>(collectionName);
            var filter = Builders<ToolModel>.Filter.Where(c=>c.Name.ToLower().Contains(filterStr));
            return collection.Find(filter).ToList() ;
        }
        public List<ToolModel> GetDataById(string id)
        {
            var collection = DBHelper.GetCollection<ToolModel>(collectionName);
            var filter = Builders<ToolModel>.Filter.Eq(c=>c.Id,id);
            return collection.Find(filter).ToList();
        }
        public Task Insert(ToolModel obj)
        {
            var collection = DBHelper.GetCollection<ToolModel>(collectionName);
            return collection.InsertOneAsync(obj);
        }

        public Task Update(ToolModel obj)
        {
            var collection = DBHelper.GetCollection<ToolModel>(collectionName);
            var filter = Builders<ToolModel>.Filter.Eq(c => c.Id, obj.Id);
            return collection.ReplaceOneAsync(filter,obj,new ReplaceOptions { IsUpsert = true });
        }
       
    }
}
