using System;

namespace Modelo
{
    public class Libro
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Imagen { get; set; }
        public int Stock { get; set; }
        public DateTime FechaPublicacion { get; set; }
    }
}