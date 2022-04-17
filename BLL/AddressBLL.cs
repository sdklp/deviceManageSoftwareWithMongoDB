using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class AddressBLL
    {
        AddressDAL addressDAL = new AddressDAL();
       
        public Task Delete(string id)
        {
            return addressDAL.Delete(id);
        }
        public List<AddressModel> GetDataById(string filterStr)
        {
            return addressDAL.GetDataById(filterStr);
        }
        public List<AddressModel> GetDataByPid(string filterStr)
        {
            return addressDAL.GetDataByPid(filterStr);
        }
        public List<AddressModel> GetDataByName(string filterStr)
        {
            return addressDAL.GetDataByName(filterStr);
        }
        public Task Save(AddressModel obj, EntityState objState)
        {
            if (objState==EntityState.Added)
            {
                return addressDAL.Insert(obj);
            }
            if (objState==EntityState.Changed)
            {
                return addressDAL.Update(obj);
            }
            return null;
        }
    }
}
