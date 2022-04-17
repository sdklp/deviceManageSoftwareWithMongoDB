using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class PhoneBookBLL
    {
        PhoneBookDAL phoneBookDAL = new PhoneBookDAL();
        public Task Delete(string id)
        {
            return phoneBookDAL.Delete(id);
        }
        public Task Save(PhoneBookModel phoneBook,EntityState entityState)
        {
            if (entityState==EntityState.Added)
            {
                return phoneBookDAL.Insert(phoneBook);
            }
            if (entityState==EntityState.Changed)
            {
                return phoneBookDAL.Update(phoneBook);
            }
            return null;
        }
        public List<PhoneBookModel> GetAll()
        {
            return phoneBookDAL.GetAll();
        }
    }
}
