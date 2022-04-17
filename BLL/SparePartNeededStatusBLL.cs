using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class SparePartNeededStatusBLL
    {
        SparePartNeededStatusDAL sparePartNeededStatusDAL = new SparePartNeededStatusDAL();
        public Task Delete(string id)
        {
            return sparePartNeededStatusDAL.Delete(id);
        }

        public List<SparePartNeededStatusModel> GetAll()
        {
            return sparePartNeededStatusDAL.GetAll();
        }

        public List<SparePartNeededStatusModel> GetDataByFilter(string filterStr)
        {
            throw new NotImplementedException();
        }

        public Task Save(SparePartNeededStatusModel obj,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return sparePartNeededStatusDAL.Insert(obj);
            }
            if (entityState==EntityState.Changed)
            {
                return sparePartNeededStatusDAL.Update(obj);
            }
            return null;
        }
    }
}
