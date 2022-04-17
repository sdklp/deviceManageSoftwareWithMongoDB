using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ApModel
    {
        [BsonId][BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string WorkId { get; set; }
        public string IQAMA { get; set; }
        public string IdExpireDate { get; set; }
        public string IqamaExpireDate { get; set; }
        public string ReturnDate { get; set; }
        public int Period { get; set; }
        public string NexVacationDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Remark { get; set; }
    }
}
