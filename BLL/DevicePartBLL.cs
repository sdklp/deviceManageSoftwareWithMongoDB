using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class DevicePartBLL
    {
        DevicePartDAL dpDAL = new DevicePartDAL();
        EntityState objState;
        public List<DevicePartModel>GetAll()
        {
            return dpDAL.GetAll();
        }
        public List<DevicePartModel> GetDataByFilter(string filterStr)
        {
            return dpDAL.GetDataByFilter(filterStr);
        }
        public Task Save(DevicePartModel obj,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return dpDAL.Insert(obj);
            }
            if (entityState==EntityState.Changed)
            {
                return dpDAL.Update(obj);
            }
            return null;
        }
        public Task Delete(string id,EntityState entityState)
        {
            if (entityState==EntityState.Deleted)
            {
                return dpDAL.Delete(id);
            }
            return null;
        }
    }
}
