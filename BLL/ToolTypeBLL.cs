using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class ToolTypeBLL
    {
        ToolTypeDAL toolTypeDAL = new ToolTypeDAL();
        public Task Delete(string id)
        {
            return toolTypeDAL.Delete(id);
        }

        public List<ToolTypeModel> GetAll()
        {
            return toolTypeDAL.GetAll();
        }

        public List<ToolTypeModel> GetDataByFilter(string filterStr)
        {
            throw new NotImplementedException();
        }

        public Task Save(ToolTypeModel obj,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return toolTypeDAL.Insert(obj);
            }
            if (entityState==EntityState.Changed)
            {
                return toolTypeDAL.Update(obj);
            }
            return null;
        }
    }
}
