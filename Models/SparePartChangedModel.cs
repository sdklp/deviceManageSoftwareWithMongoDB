using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SparePartChangedModel
    {
        [BsonId][BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string ID { get; set; }
        public string Did { get; set; }
        public string Pid { get; set; }
        public string ChangedDate { get; set; }
        public string DeviceName { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceNo { get; set; }
        public string DeviceLocation { get; set; }
        public string DeviceKKS { get; set; }
        public string SubDevice { get; set; }
        public string SparePartName { get; set; }
        public string SparePartModel { get; set; }
        public string SparePartNo { get; set; }
        public string Units { get; set; }
        public int Qty { get; set; }
        public string Remark { get; set; }
    }
}
