using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class LocationBLL
    {
        LocationDAL locationDAL = new LocationDAL();
        public Task Delete(string id)
        {
            return locationDAL.Delete(id);
        }
        public List<LocationModel> GetAll()
        {
            return locationDAL.GetAll();
        }
        public List<LocationModel> GetDataByFilter(string filterStr)
        {
            return locationDAL.GetDataByFilter(filterStr);
        }
        public List<LocationModel> GetDataByLocationName(string filterStr)
        {
            return locationDAL.GetDataByLocationName(filterStr);
        }
        public List<LocationModel> GetDataById(string id)
        {
            return locationDAL.GetDataById(id);
        }
        public List<LocationModel> GetDataByPid(string pid)
        {
            return locationDAL.GetDataByPid(pid);
        }
        public Task Save(LocationModel obj,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return locationDAL.Insert(obj);
            }
            if (entityState==EntityState.Changed)
            {
                return locationDAL.Update(obj);
            }
            return null;
        }
    }
}
