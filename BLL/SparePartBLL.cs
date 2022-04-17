using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class SparePartBLL
    {
        SparePartDAL sDAL = new SparePartDAL();
        EntityState objState;
        public Task Save(SparePartModel obj,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return sDAL.Insert(obj);
            }
            if (entityState==EntityState.Changed)
            {
                return sDAL.Update(obj);
            }
            return null;
        }
        public Task Delete(string id,EntityState entity)
        {
            if (entity==EntityState.Deleted)
            {
                return sDAL.Delete(id);
            }
            return null;
        }
        public List<SparePartModel> GetAll()
        {
            return sDAL.GetAll();
        }
        public List<SparePartModel> GetDataByFilter(string filter)
        {
            return sDAL.GetDataByFilter(filter);
        }
    }
}
