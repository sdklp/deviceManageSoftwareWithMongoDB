using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MaintenanceModel
    {
        [BsonId][BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string PTW { get; set; }
        public string AP { get; set; }
        public string Detail { get; set; }
        public DeviceModel Device { get; set; }
        public string DeviceId { get; set; }
        public string DeviceLocation { get; set; }
        public string DeviceName { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceKKS { get; set; }
        public string DeviceNo { get; set; }
        public string SubDevice { get; set; }
        public string FaultSummary { get; set; }
        public string FaultDetail { get; set; }
        public string DealWithSummary { get; set; }
        public string DealWithDetail { get; set; }
        public string Remark { get; set; }

        //public MaintenanceModel(DeviceModel device)
        //{
        //    DeviceId = device.Id;
        //    DeviceKKS = device.DKKS;
        //    DeviceLocation = device.Location;
        //    DeviceName = device.DName;
        //    DeviceModel = device.DModel;
        //    DeviceNo = device.DNo;
        //}
    }
}
