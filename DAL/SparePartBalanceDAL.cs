using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class SparePartBalanceDAL : IModel<SparePartBalanceModel>
    {
        string collectionName = "SparePartBalance";
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<SparePartBalanceModel> GetAll()
        {
            var collection = DBHelper.GetCollection<SparePartBalanceModel>(collectionName);
            return collection.Find(_=>true).ToList();
        }

        public List<SparePartBalanceModel> GetDataByFilter(string filterStr)
        {
            var collection = DBHelper.GetCollection<SparePartBalanceModel>(collectionName);
            var filter = Builders<SparePartBalanceModel>.Filter.Eq(c=>c.Pid,filterStr);
            return collection.Find(filter).ToList() ;
        }
        public List<SparePartBalanceModel> GetDataByPid(string filterStr)
        {
            throw new NotImplementedException();
        }

        public Task Insert(SparePartBalanceModel obj)
        {
            var collection = DBHelper.GetCollection<SparePartBalanceModel>(collectionName);
            return collection.InsertOneAsync(obj);
        }

        public Task Update(SparePartBalanceModel obj)
        {
            var collection = DBHelper.GetCollection<SparePartBalanceModel>(collectionName);
            var filter = Builders<SparePartBalanceModel>.Filter.Eq(c=>c.Id,obj.Id);
            return collection.ReplaceOneAsync(filter,obj,new ReplaceOptions { IsUpsert = true });
        }
    }
}
