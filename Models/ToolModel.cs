using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ToolModel
    {
        [BsonId][BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string ToolType { get; set; }
        public string Units { get; set; }
        public int Qty { get; set; }
        public int Balance { get; set; }
        public string Remark { get; set; }
    }
}
