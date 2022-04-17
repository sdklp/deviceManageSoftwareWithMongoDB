using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class DeviceBLL
    {
        DeviceDAL deviceDAL = new DeviceDAL();
        public Task Save(DeviceModel device, EntityState entityState)
        {
            if (entityState == EntityState.Added)
            {
                return deviceDAL.Insert(device);
            }
            if (entityState == EntityState.Changed)
            {
                return deviceDAL.Update(device);
            }
            return null;
        }
        public Task Delete(string id, EntityState entityState)
        {
            if (entityState == EntityState.Deleted)
            {
                return deviceDAL.Delete(id);
            }
            return null;
        }
        public List<DeviceModel> GetAll()
        {
            return deviceDAL.GetAll();
        }
        public List<DeviceModel> GetDataByFilter(string filter)
        {
            return deviceDAL.GetDataByFilter(filter);
        }
        public List<DeviceModel> GetDataByFilter(string locationStr, string deviceNoStr)
        {
            return deviceDAL.GetDataByFilter(locationStr, deviceNoStr);
        }
    }
}
