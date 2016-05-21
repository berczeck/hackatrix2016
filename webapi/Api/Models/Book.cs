using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Book
    {
        [BsonElement("_id")]
        public ObjectId Id { get; set; }
        [BsonElement("genre")]
        public string Genre { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("isbn")]
        public string Isbn { get; set; }
        [BsonElement("author")]
        public string  Autor { get; set; }
        [BsonElement("tags")]
        public string[] Tags { get; set; }
        [BsonElement("imageUrl")]
        public string ImageUrl { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        [BsonElement("borrowed")]
        public bool Borrowed { get; set; }
        [BsonElement("owner")]
        public ObjectId OwnerId { get; set; }
        [BsonElement("requestedById")]
        public ObjectId RequestedById { get; set; }
        [BsonElement("comments")]
        public Comment[] Comments { get; set; }
    }
}