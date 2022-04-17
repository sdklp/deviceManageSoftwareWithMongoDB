using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Models;


namespace DAL
{
    public class SparePartDAL:IModel<SparePartModel>
    {
        string collectionName = "SparePart";
        public Task Delete(string id)
        {
            var sparePartCollection = DBHelper.GetCollection<SparePartModel>(collectionName);
           
            return sparePartCollection.DeleteOneAsync(c=>c.Id==id);
        }

        public List<SparePartModel> GetAll()
        {
            var sparePartCollection = DBHelper.GetCollection<SparePartModel>(collectionName);
            return sparePartCollection.Find(_ => true).ToList();
            //return results.ToList();
        }

        public List<SparePartModel> GetDataByFilter(string filterStr)
        {
            var sparePartCollection = DBHelper.GetCollection<SparePartModel>(collectionName);
            var filter = Builders<SparePartModel>.Filter.Where(c=>c.PName.ToLower().Contains(filterStr) |c.PModel.ToLower().Contains(filterStr));
            return sparePartCollection.Find(filter).ToList();
        }

        public Task Insert(SparePartModel obj)
        {
            var sparePartCollection = DBHelper.GetCollection<SparePartModel>(collectionName);
            return sparePartCollection.InsertOneAsync(obj);
        }

        public Task Update(SparePartModel obj)
        {
            var sparePartCollection = DBHelper.GetCollection<SparePartModel>(collectionName);
            var filter = Builders<SparePartModel>.Filter.Eq(c=>c.Id,obj.Id);
            return sparePartCollection.ReplaceOneAsync(filter,obj,new ReplaceOptions {IsUpsert=true });
        }
    }
}
