using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class SubDeviceBLL
    {
        SubDeviceDAL subDeviceDAL = new SubDeviceDAL();
        public Task Delete(string id)
        {
            return subDeviceDAL.Delete(id);
        }

        public List<SubDeviceModel> GetAll()
        {
            return subDeviceDAL.GetAll();
        }

        public List<SubDeviceModel> GetDataByFilter(string filterStr)
        {
            return subDeviceDAL.GetDataByFilter(filterStr);
        }

        public Task Save(SubDeviceModel obj,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return subDeviceDAL.Insert(obj);
            }
            if (entityState==EntityState.Changed)
            {
                return subDeviceDAL.Update(obj);
            }
            return null;
        }
        public List<SubDeviceModel> GetDataByPid(string filterStr)
        {
            return subDeviceDAL.GetDataByPid(filterStr);
        }
        public List<SubDeviceModel> GetDataBySubDeviceName(string filterStr)
        {
            return subDeviceDAL.GetDataBySubDeviceName(filterStr);
        }
        public List<SubDeviceModel> GetDataById(string filterStr)
        {
            return subDeviceDAL.GetDataById(filterStr);
        }
    }
}
