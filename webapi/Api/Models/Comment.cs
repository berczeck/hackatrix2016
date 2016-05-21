using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;

namespace Api.Models
{
    public class Comment
    {
        [BsonElement("text")]
        public string Text { get; set; }
        [BsonElement("bookId")]
        public ObjectId BookId { get; set; }
        [BsonElement("InterestedUserId")]
        public ObjectId InterestedUserId { get; set; }
    }
}