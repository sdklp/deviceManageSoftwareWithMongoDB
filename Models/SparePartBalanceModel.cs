using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SparePartBalanceModel
    {
        [BsonId][BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Pid { get; set; }
        public string Units { get; set; }
        public int Qty { get; set; }
        public string InOut { get; set; }
        public string Remark { get; set; }
        public string Person { get; set; }
        public string Date { get; set; }
    }
}
