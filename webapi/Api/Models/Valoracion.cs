using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Valoracion
    {
        public string User { get; set; }
        public string Book { get; set; }
        public int Punto { get; set; }
    }
}