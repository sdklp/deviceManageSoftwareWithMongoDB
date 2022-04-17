using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class CompanyBLL
    {
        CompanyDAL companyDAL = new CompanyDAL();
        public List<CompanyModel> GetAll()
        {
            return companyDAL.GetAll();
        }
        public List<CompanyModel> GetDataByFilter(string filterStr)
        {
            return companyDAL.GetDataByFilter(filterStr);
        }
        public Task Delete(string id)
        {
            return companyDAL.Delete(id);
        }
        public Task Save(CompanyModel obj,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return companyDAL.Insert(obj);
            }
            if (entityState==EntityState.Changed)
            {
                return companyDAL.Update(obj);
            }
            return null;
        }
        public List<CompanyModel> GetAllCompany()
        {
            return companyDAL.GetAllCompany();
        }
        public List<CompanyModel> GetAllAgency()
        {
            return companyDAL.GetAllAgency();
        }
        public List<CompanyModel> GetAllCompanyByFilter(string filterStr)
        {
            return companyDAL.GetAllCompanyByFilter(filterStr);
        }
        public List<CompanyModel> GetAllAgencyByFilter(string filterStr)
        {
            return companyDAL.GetAllAgencyByFilter(filterStr);
        }
    }
}
