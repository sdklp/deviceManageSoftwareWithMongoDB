using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Models
{
    public class DeviceModel
    {
        [BsonId][BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Location { get; set; }
        public string DName { get; set; }
        public string DModel { get; set; }
        public string DKKS { get; set; }
        public string DNo { get; set; }
        public string DStatus { get; set; }
        public string Pid { get; set; }
        public string Manufacturer { get; set; }
        public string Agency { get; set; }
        public string DRemark { get; set; }
        public string SubDevice { get; set; }
    }
}
