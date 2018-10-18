using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Entidades
{
    public class Libro
    {
        public int IdLibro { get; private set; }
        public Reserva IdReserva { get; private set; }
        public Alumno CodigoAlumno { get; private set; }
        public string TituloLibro { get; private set; }
        public string AutorLibro { get; set; }
        public bool EstaDisponible { get; set; }

        public Prestamo Prestamo
        {
            get => default(Prestamo);
            set
            {
            }
        }
    }
}
