using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Models
{
    public class SparePartNeededModel
    {
        [BsonId][BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        public string DocID { get; set; }
        public string Status { get; set; }
        public string RequireDate { get; set; }
        public string ReleaseDate { get; set; }
        public string Remark { get; set; }
        public DeviceModel Device { get; set; }
        public string SubDevice { get; set; }
        public string DeviceID { get; set; }
        public string DeviceName { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceKKS { get; set; }
        public string DeviceLocation { get; set; }
        public string DeviceNo { get; set; }
        public SparePartModel SparePart { get; set; }
        public string SparePartID { get; set; }
        public string SparePartName { get; set; }
        public string SparePartModel { get; set; }
        public string SparePartNo { get; set; }
        public string Units { get; set; }
        public int Qty { get; set; }
        public SparePartNeededModel(DeviceModel device,SparePartModel sparePart)
        {
            Device = device;
            DeviceID = device.Id;
            DeviceName = device.DName;
            DeviceModel = device.DModel;
            DeviceKKS = device.DKKS;
            DeviceLocation = device.Location;
            DeviceNo = device.DNo;
            SparePart = sparePart;
            SparePartID = sparePart.Id;
            SparePartName = sparePart.PName;
            SparePartModel = sparePart.PModel;
            SparePartNo = sparePart.PNo;
        }

    }
}
