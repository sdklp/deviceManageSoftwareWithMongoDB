using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class MaintenanceBLL
    {
       
        MaintenanceDAL mDAL = new MaintenanceDAL();
        public Task Save(MaintenanceModel obj,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return mDAL.Insert(obj);
            }
            if (entityState==EntityState.Changed)
            {
                return mDAL.Update(obj);
            }
            return null;
        }
        public Task Delete(string id)
        {
            return mDAL.Delete(id);
        }
        public List<MaintenanceModel> GetAll()
        {
            return mDAL.GetAll();
        }
        public List<MaintenanceModel> GetDataByFilter(string filterStr)
        {
            return mDAL.GetDataByFilter(filterStr);
        }
    }
}
