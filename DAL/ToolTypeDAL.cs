using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class ToolTypeDAL : IModel<ToolTypeModel>
    {
        string collectionName = "ToolType";
        public Task Delete(string id)
        {
            var collection = DBHelper.GetCollection<ToolTypeModel>(collectionName);
            return collection.DeleteOneAsync(c => c.Id == id);
        }

        public List<ToolTypeModel> GetAll()
        {
            var collection = DBHelper.GetCollection<ToolTypeModel>(collectionName);
            return collection.Find(_ => true).ToList() ;
        }

        public List<ToolTypeModel> GetDataByFilter(string filterStr)
        {
            throw new NotImplementedException();
        }

        public Task Insert(ToolTypeModel obj)
        {
            var collection = DBHelper.GetCollection<ToolTypeModel>(collectionName);
            return collection.InsertOneAsync(obj);
        }

        public Task Update(ToolTypeModel obj)
        {
            var collection = DBHelper.GetCollection<ToolTypeModel>(collectionName);
            var filter = Builders<ToolTypeModel>.Filter.Eq(c => c.Id, obj.Id);
            return collection.ReplaceOneAsync(filter,obj,new ReplaceOptions { IsUpsert = true });
        }
    }
}
