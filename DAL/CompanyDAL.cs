using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL
{
    public class CompanyDAL : IModel<CompanyModel>
    {
        string collectionName = "Company";
        public Task Delete(string id)
        {
            var collection = DBHelper.GetCollection<CompanyModel>(collectionName);
            return collection.DeleteOneAsync(c=>c.Id==id);
        }

        public List<CompanyModel> GetAll()
        {
            var collection = DBHelper.GetCollection<CompanyModel>(collectionName);
            return collection.Find(_ => true).ToList() ;
        }
        public List<CompanyModel> GetAllCompany()
        {
            var collection = DBHelper.GetCollection<CompanyModel>(collectionName);
            var filter = Builders<CompanyModel>.Filter.Eq(c=>c.CompanyType, "Company")| Builders<CompanyModel>.Filter.Eq(c => c.CompanyType, "Both");
            return collection.Find(filter).ToList();
        }
        public List<CompanyModel> GetAllAgency()
        {
            var collection = DBHelper.GetCollection<CompanyModel>(collectionName);
            var filter = Builders<CompanyModel>.Filter.Eq(c => c.CompanyType, "Agency") | Builders<CompanyModel>.Filter.Eq(c => c.CompanyType, "Both");
            return collection.Find(filter).ToList();
        }
        public List<CompanyModel> GetAllCompanyByFilter(string filterStr)
        {
            var collection = DBHelper.GetCollection<CompanyModel>(collectionName);
            var filter = (Builders<CompanyModel>.Filter.Eq(c => c.CompanyType, "Company") | Builders<CompanyModel>.Filter.Eq(c => c.CompanyType, "Both"))&Builders<CompanyModel>.Filter.Where(c=>c.CompanyName.ToLower().Contains(filterStr));
            return collection.Find(filter).ToList();
        }
        public List<CompanyModel> GetAllAgencyByFilter(string filterStr)
        {
            var collection = DBHelper.GetCollection<CompanyModel>(collectionName);
            var filter = (Builders<CompanyModel>.Filter.Eq(c => c.CompanyType, "Agency") | Builders<CompanyModel>.Filter.Eq(c => c.CompanyType, "Both")) & Builders<CompanyModel>.Filter.Where(c => c.CompanyName.ToLower().Contains(filterStr));
            return collection.Find(filter).ToList();
        }
        public List<CompanyModel> GetDataByFilter(string filterStr)
        {
            var collection = DBHelper.GetCollection<CompanyModel>(collectionName);
            var filter = Builders<CompanyModel>.Filter.Where(c => c.CompanyName.ToLower().Contains(filterStr) | c.Country.ToLower().Contains(filterStr)|c.Province.ToLower().Contains(filterStr)|c.Person.ToLower().Contains(filterStr)) ;
            return collection.Find(filter).ToList() ;
        }

        public Task Insert(CompanyModel obj)
        {
            var collection = DBHelper.GetCollection<CompanyModel>(collectionName);
            return collection.InsertOneAsync(obj);
        }

        public Task Update(CompanyModel obj)
        {
            var collection = DBHelper.GetCollection<CompanyModel>(collectionName);
            var filter = Builders<CompanyModel>.Filter.Eq(c=>c.Id,obj.Id);
            return collection.ReplaceOneAsync(filter,obj,new ReplaceOptions { IsUpsert = true });
        }
    }
}
