using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class ToolLendBLL
    {
        ToolLendDAL toolLendDAL = new ToolLendDAL();
        public Task Save(ToolLendModel obj,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return toolLendDAL.Insert(obj);
            }
            if (entityState==EntityState.Changed)
            {
                return toolLendDAL.Update(obj);
            }
            return null;
        }
        public List<ToolLendModel> GetAll()
        {
            return toolLendDAL.GetAll();
        }
        public Task Delete(string id)
        {
            return toolLendDAL.Delete(id);
        }
        public List<ToolLendModel> GetDataByToolIdNotFinish(string filterStr)
        {
            return toolLendDAL.GetDataByToolIdNotFinish(filterStr);
        }
        public List<ToolLendModel> GetDataByFilter(string filterStr)
        {
            return toolLendDAL.GetDataByFilter(filterStr);
        }
        public List<ToolLendModel> GetDataByFilterNotFinish(string filterStr)
        {
            return toolLendDAL.GetDataByFilterNotFinish(filterStr);
        }
        public List<ToolLendModel> GetDataByToolId(string filterStr)
        {
            return toolLendDAL.GetDataByToolId(filterStr);
        }
    }
}
