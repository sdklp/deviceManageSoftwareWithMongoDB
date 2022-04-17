using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ToolLendModel
    {
        [BsonId][BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string ToolId { get; set; }
        public string ToolName { get; set; }
        public string ToolModel { get; set; }       
        public string LendPerson { get; set; }
        public string LendDate { get; set; }              
        public string Units { get; set; }
        public string ReturnPerson { get; set; }
        public string ReturnDate { get; set; }
        public int LendQty { get; set; }
        public int ReturnQty { get; set; }
        public int DiffQty { get; set; }               
        public string Remark { get; set; }

    }
}
