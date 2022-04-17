using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Models
{
    public class SparePartModel
    {
        [BsonId][BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string PName { get; set; }
        public string PModel { get; set; }
        public string PNo { get; set; }
        public string Units { get; set; }        
        public int Balance { get; set; }
        public int MinQty { get; set; }
        public int MaxQty { get; set; }
        public string Detail { get; set; }
        public string Manufacturer { get; set; }
        public string Agency { get; set; }
    }
}
