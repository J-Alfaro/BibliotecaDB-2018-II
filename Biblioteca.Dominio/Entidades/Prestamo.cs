using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Entidades
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public Libro IdLibro { get; private set; }
        public Reserva IdReserva { get; private set; }
        public Alumno IdAlumno { get; private set; }
        public DateTime FechaPrestamo { get; private set; }        
         public string EstadoPrestamo { get; private set; }

        internal Bibliotecario Bibliotecario
        {
            get => default(Bibliotecario);
            set
            {
            }
        }
    }
}
