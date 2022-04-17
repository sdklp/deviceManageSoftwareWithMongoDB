using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    
    public class SparePartNeededBLL
    {
        SparePartNeededDAL spNeedDAL = new SparePartNeededDAL();
        public List<SparePartNeededModel> GetAll()
        {
            return spNeedDAL.GetAll();
        }
        public List<SparePartNeededModel> GetDataByFilter(string filterStr)
        {
            return spNeedDAL.GetDataByFilter(filterStr);
        }
        public Task Save(SparePartNeededModel obj,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return spNeedDAL.Insert(obj);
            }
            if (entityState==EntityState.Changed)
            {
                return spNeedDAL.Update(obj);
            }
            return null;
            
        }
        public Task Delete(string id)
        {
            return spNeedDAL.Delete(id);
        }
    }
}
