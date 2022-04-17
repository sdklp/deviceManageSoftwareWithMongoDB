using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class CompanyModel
    {
        [BsonId][BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
        public string Person { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }

        public string Email { get; set; }
        public string CompanyType { get; set; }
        public string Remark { get; set; }

    }
}
