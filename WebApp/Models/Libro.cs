using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public String ISBN { get ; set; }
        public String Titulo { get; set; }
        public int GeneroId { get; set; }
        public int AutorId { get; set; }
        public int EditorialId { get; set; }
    }
}