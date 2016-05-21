using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Book
    {
        public string Genero { get; set; }
        public string Codigo { get; set; }
        public string  Autor { get; set; }
        public string[] MyProperty { get; set; }
    }
}

//{[]}