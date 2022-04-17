using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class PhoneBookDAL:IModel<PhoneBookModel>
    {
        string collectionName = "PhoneBook";

        public Task Delete(string id)
        {
            var collection = DBHelper.GetCollection<PhoneBookModel>(collectionName);
            return collection.DeleteOneAsync(c=>c.Id==id);
        }

        public List<PhoneBookModel> GetAll()
        {
            var collection = DBHelper.GetCollection<PhoneBookModel>(collectionName);
            return collection.Find(_ => true).ToList() ;
        }

        public List<PhoneBookModel> GetDataByFilter(string filterStr)
        {
            throw new NotImplementedException();
        }

        public Task Insert(PhoneBookModel obj)
        {
            var collection = DBHelper.GetCollection<PhoneBookModel>(collectionName);
            return collection.InsertOneAsync(obj);
        }

        public Task Update(PhoneBookModel obj)
        {
            var collection = DBHelper.GetCollection<PhoneBookModel>(collectionName);
            var filter = Builders<PhoneBookModel>.Filter.Eq(c=>c.Id,obj.Id);
            return collection.ReplaceOneAsync(filter,obj,new ReplaceOptions { IsUpsert = true });
        }
    }
}
