using System;

namespace Modelo
{
    public class Prestamo
    {
        public int ID { get; set; }
        public int ID_Usuario { get; set; }
        public int ID_Libro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public bool Devuelto { get; set; }
    }
}