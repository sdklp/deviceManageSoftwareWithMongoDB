using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FactoryModel
    {
        public string Id { get; set; }
        public string FName { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
        public string Person { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int Ftype { get; set; }//1:Manufacturor;2:Agency;3:Manufacturor and Agency
        public string Remark { get; set; }
    }
}
