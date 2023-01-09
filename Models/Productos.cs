using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Técnica.Models
{
    public class Productos
    {
        public int id { get; set;}
        public string? title { get; set;}
        public float price { get; set;}
        public string? description { get; set;}
        public string? category { get; set;}
        public string? image { get; set;}
    }
}
