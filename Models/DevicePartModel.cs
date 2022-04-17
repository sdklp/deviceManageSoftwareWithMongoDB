using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class DevicePartModel
    {
        [BsonId][BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DeviceModel Device { get; set; }
        public string Did { get; set; }
        public string Location { get; set; }
        public string DName { get; set; }
        public string DModel { get; set; }
        public string DKKS { get; set; }
        public string DNo { get; set; }
        public string SubDevice { get; set; }
        public SparePartModel SparePart { get; set; }
        public string Pid { get; set; }
        public string PName { get; set; }
        public string PModel { get; set; }
        public string PNo { get; set; }
        public string Units { get; set; }
        public int Qty { get; set; }
        public string Remark { get; set; }
        public DevicePartModel(DeviceModel device,SparePartModel sparePart)
        {
            Did = device.Id;
            Location = device.Location;
            DName = device.DName;
            DModel = device.DModel;
            DKKS = device.DKKS;
            DNo = device.DNo;
            Pid = sparePart.Id;
            PName = sparePart.PName;
            PModel = sparePart.PModel;
            PNo = sparePart.PNo;
        }
    }
}
