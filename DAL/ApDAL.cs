using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class ApDAL : IModel<ApModel>
    {
        string collectionName = "Ap";
        public Task Delete(string id)
        {
            var collection = DBHelper.GetCollection<ApModel>(collectionName);
            return collection.DeleteOneAsync(c => c.Id == id);
        }

        public List<ApModel> GetAll()
        {
            var collection = DBHelper.GetCollection<ApModel>(collectionName);
            return collection.Find(_ => true).ToList();
        }

        public List<ApModel> GetDataByFilter(string filterStr)
        {
            var collection = DBHelper.GetCollection<ApModel>(collectionName);
            var filter = Builders<ApModel>.Filter.Where(c => c.Name.ToLower().Contains(filterStr));
            return collection.Find(filter).ToList();
        }

        public Task Insert(ApModel obj)
        {
            var collection = DBHelper.GetCollection<ApModel>(collectionName);
            return collection.InsertOneAsync(obj);
        }

        public Task Update(ApModel obj)
        {
            var collection = DBHelper.GetCollection<ApModel>(collectionName);
            var filter = Builders<ApModel>.Filter.Eq(c=>c.Id,obj.Id);
            return collection.ReplaceOneAsync(filter, obj, new ReplaceOptions { IsUpsert = true });
        }
    }
}
