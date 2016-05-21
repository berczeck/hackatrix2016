using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Account
    {
        [BsonElement("identifier")]
        public string Identifier { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("user")]
        public string User { get; set; }
    }
}