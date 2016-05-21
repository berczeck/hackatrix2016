using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class User
    {
        [BsonElement("iedntificador")]
        public string Identificador { get; set; }
        [BsonElement("nombre")]
        public string Nombre { get; set; }
        [BsonElement("usuario")]
        public string Usuario { get; set; }
    }
}