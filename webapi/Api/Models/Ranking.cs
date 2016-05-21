using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson.Serialization.Attributes;
using System.Web;

namespace Api.Models
{
    public class Ranking
    {
        [BsonElement("rankedById")]
        public ObjectId RankedById { get; set; }
        [BsonElement("text")]
        public int Points { get; set; }
    }
}