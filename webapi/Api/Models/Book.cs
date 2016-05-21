using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Book
    {
        [BsonElement("genero")]
        public string Genero { get; set; }
        [BsonElement("isbn")]
        public string Isbn { get; set; }
        [BsonElement("genero")]
        public string  Autor { get; set; }
        [BsonElement("genero")]
        public string[] Tags { get; set; }
        [BsonElement("genero")]
        public string UrlImagen { get; set; }
        [BsonElement("descripcion")]
        public string Descripcion { get; set; }
        [BsonElement("identificador")]
        public string Identificador { get; set; }
        [BsonElement("comentarios")]
        public Comentario[] Comentarios { get; set; }
    }
}

//{[]}