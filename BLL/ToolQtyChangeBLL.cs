using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class ToolQtyChangeBLL
    {
        ToolQtyChangeDAL toolQtyDAL = new ToolQtyChangeDAL();
        public Task Save(ToolQtyChangeModel obj,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return toolQtyDAL.Insert(obj);
            }
            if (entityState==EntityState.Changed)
            {
                return toolQtyDAL.Update(obj);
            }
            return null;

        }
        public List<ToolQtyChangeModel> GetAll()
        {
            return toolQtyDAL.GetAll();
        }
        public List<ToolQtyChangeModel> GetDataByToolId(string filterStr)
        {
            return toolQtyDAL.GetDataByToolId(filterStr);
        }
    }
}
