using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PartChangedModel
    {
        public string Id { get; set; }
        public MaintenanceModel maintenance { get; set; }
        public SparePartModel SparePart { get; set; }
        public UnitsModel Units { get; set; }
        public int Qty { get; set; }
        public string Remark { get; set; }
    }
}
