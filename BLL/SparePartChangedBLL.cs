using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class SparePartChangedBLL
    {
        SparePartChangedDAL spChangedDAL = new SparePartChangedDAL();
        public Task Delete(string id)
        {
            return spChangedDAL.Delete(id);
        }
        public List<SparePartChangedModel> GetAll()
        {
            return spChangedDAL.GetAll();
        }
        public List<SparePartChangedModel> GetDataByFilter(string filterStr)
        {
            return spChangedDAL.GetDataByFilter(filterStr);
        }
        public Task Save(SparePartChangedModel obj,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return spChangedDAL.Insert(obj);
            }
            if (entityState==EntityState.Changed)
            {
                return spChangedDAL.Update(obj);
            }
            return null;
        }
    }
}
