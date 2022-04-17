using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class SparePartBalanceBLL
    {
        SparePartBalanceDAL spbDAL = new SparePartBalanceDAL();
        public Task Save(SparePartBalanceModel obj,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return spbDAL.Insert(obj);
            }
            if (entityState==EntityState.Changed)
            {
                return spbDAL.Update(obj);
            }
            return null;
        }
        public List<SparePartBalanceModel>GetAll()
        {
            return spbDAL.GetAll();
        }
        public List<SparePartBalanceModel>GetDataByPid(string pid)
        {
            return spbDAL.GetDataByFilter(pid);
        }
    }
}
