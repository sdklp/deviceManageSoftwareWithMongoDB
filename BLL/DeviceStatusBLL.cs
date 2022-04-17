using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class DeviceStatusBLL
    {
        DeviceStatusDAL deviceStatusDAL = new DeviceStatusDAL();
        public Task Delete(string id)
        {
            return deviceStatusDAL.Delete(id);
        }

        public List<DeviceStatusModel> GetAll()
        {
            return deviceStatusDAL.GetAll();
        }

        public List<DeviceStatusModel> GetDataByFilter(string filterStr)
        {
            throw new NotImplementedException();
        }

        public Task Save(DeviceStatusModel obj,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return deviceStatusDAL.Insert(obj);
            }
            if (entityState==EntityState.Changed)
            {
                return deviceStatusDAL.Update(obj);
            }
            return null;
        }

       
    }
}
