using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class ToolQtyChangeDAL : IModel<ToolQtyChangeModel>
    {
        string collectionName = "ToolQtyChanged";
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<ToolQtyChangeModel> GetAll()
        {
            var collection = DBHelper.GetCollection<ToolQtyChangeModel>(collectionName);
            return collection.Find(_ => true).ToList();
        }

        public List<ToolQtyChangeModel> GetDataByFilter(string filterStr)
        {
            throw new NotImplementedException();
        }
        public List<ToolQtyChangeModel> GetDataByToolId(string filterStr)
        {
            var collection = DBHelper.GetCollection<ToolQtyChangeModel>(collectionName);
            var filter = Builders<ToolQtyChangeModel>.Filter.Eq(c=>c.ToolId,filterStr);
            return collection.Find(filter).ToList(); 
        }
        public Task Insert(ToolQtyChangeModel obj)
        {
            var collection = DBHelper.GetCollection<ToolQtyChangeModel>(collectionName);
            return collection.InsertOneAsync(obj);
        }

        public Task Update(ToolQtyChangeModel obj)
        {
            var collection = DBHelper.GetCollection<ToolQtyChangeModel>(collectionName);
            var filter = Builders<ToolQtyChangeModel>.Filter.Eq(c=>c.Id,obj.Id);
            return collection.ReplaceOneAsync(filter,obj,new ReplaceOptions { IsUpsert = true });
        }
    }
}
