using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IModel<T>where T:class
    {
        List<T>GetAll();
        List<T>GetDataByFilter(string filterStr);
        Task Insert(T obj);
        Task Update(T obj);
        Task Delete(string id);
    }
}
