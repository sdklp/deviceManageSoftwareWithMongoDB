using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class  LocationModel
    {

        [BsonId][BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string LName { get; set; }
        public string Pid { get; set; }
        public string Remark { get; set; }
    }
}
