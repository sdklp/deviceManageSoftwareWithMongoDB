using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ToolQtyChangeModel
    {
        public string Id { get; set; }
        public string ToolId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Action { get; set; }
        public string Units { get; set; }
        public int Qty { get; set; }
        public string Remark { get; set; }
    }
}
