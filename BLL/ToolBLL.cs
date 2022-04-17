using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class ToolBLL
    {
        ToolDAL toolDAL = new ToolDAL();
        public Task Delete(string id)
        {
            return toolDAL.Delete(id);
        }
        public Task Save(ToolModel toolModel,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return toolDAL.Insert(toolModel);
            }
            if (entityState==EntityState.Changed)
            {
                return toolDAL.Update(toolModel);
            }
            return null;
        }
        public List<ToolModel> GetDataById(string id)
        {
            return toolDAL.GetDataById(id);
        }
        public List<ToolModel> GetAll()
        {
            return toolDAL.GetAll();
        }

        public List<ToolModel> GetDataByFilter(string filterStr)
        {
            return toolDAL.GetDataByFilter(filterStr);
        }

    }
}
