using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PartNeededModel
    {
        public string Id { get; set; }
        public string RequirNo { get; set; }
        public string RequireDate { get; set; }
        public string ReleaseDate { get; set; }
        public string Status { get; set; }
        public DeviceModel Device { get; set; }
        public SubDeviceModel SubDevice { get; set; }
        public SparePartModel SparePart { get; set; }
        public UnitsModel Units { get; set; }
        public int Qty { get; set; }
        public string Remark { get; set; }
    }
}
