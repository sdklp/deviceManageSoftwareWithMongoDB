using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class UnitsBLL
    {
        UnitsDAL unitsDAL = new UnitsDAL();
        public List<UnitsModel> GetAll()
        {
            return unitsDAL.GetAll();
        }
        public Task Delete(string id)
        {
            return unitsDAL.Delete(id);
        }
        public Task Save(UnitsModel obj,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return unitsDAL.Insert(obj);
            }
            if (entityState==EntityState.Changed)
            {
                return unitsDAL.Update(obj);
            }
            return null;
        }
    }
}
