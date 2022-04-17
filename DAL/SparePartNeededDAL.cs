using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class SparePartNeededDAL : IModel<SparePartNeededModel>
    {
        private string collectionName= "SparePartNeeded";
        public Task Delete(string id)
        {
            var spNeedCollection = DBHelper.GetCollection<SparePartNeededModel>(collectionName);
            return spNeedCollection.DeleteOneAsync(c=>c.ID==id);
        }

        public List<SparePartNeededModel> GetAll()
        {
            
            var spNeedCollection = DBHelper.GetCollection<SparePartNeededModel>(collectionName);
            return spNeedCollection.Find(_ => true).ToList() ;
        }

        public List<SparePartNeededModel> GetDataByFilter(string filterStr)
        {
            
            var spNeedCollection = DBHelper.GetCollection<SparePartNeededModel>(collectionName);
            var filter = Builders<SparePartNeededModel>.Filter.Where(c=>c.DeviceLocation.ToLower().Contains(filterStr));
            return spNeedCollection.Find(filter).ToList();
        }

        public Task Insert(SparePartNeededModel obj)
        {
           
            var spNeedCollection = DBHelper.GetCollection<SparePartNeededModel>(collectionName);
            return spNeedCollection.InsertOneAsync(obj);
        }

        public Task Update(SparePartNeededModel obj)
        {
           
            var spNeedCollection = DBHelper.GetCollection<SparePartNeededModel>(collectionName);
            var filter = Builders<SparePartNeededModel>.Filter.Eq("ID",obj.ID);
            return spNeedCollection.ReplaceOneAsync(filter,obj,new ReplaceOptions { IsUpsert=true});

        }
    }
}
