using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class ApBLL
    {
        ApDAL apDAL = new ApDAL();
        public Task Delete(string id)
        {
            return apDAL.Delete(id);
        }
        public Task Save(ApModel apModel,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return apDAL.Insert(apModel);
            }
            if (entityState == EntityState.Changed)
            {
                return apDAL.Update(apModel);
            }
            return null;
        }
        public List<ApModel> GetAll()
        {
            return apDAL.GetAll();
        }

        public List<ApModel> GetDataByFilter(string filterStr)
        {
            return apDAL.GetDataByFilter(filterStr);
        }
    }
}
