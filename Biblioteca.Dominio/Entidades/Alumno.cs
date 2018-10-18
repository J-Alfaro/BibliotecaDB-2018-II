using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Entidades
{
    public class Alumno
    {
        public int CodigoAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public string ApellidoAlumno { get; set; }
        public string DireccionAlumno { get; set; }
        public string TelefonoAlumno { get; set; }

        public Reserva Reserva
        {
            get => default(Reserva);
            set
            {
            }
        }

        public static Alumno Registrar(int asCodigoAlumno, string asNombreAlumno,
            string asApellidoAlumno,string asDireccionAlumno,string asTelefonoAlumno)
        {
            return new Alumno()
            {
                CodigoAlumno = asCodigoAlumno,
                NombreAlumno = asNombreAlumno,
                ApellidoAlumno = asApellidoAlumno,
                DireccionAlumno = asDireccionAlumno,
                TelefonoAlumno = asTelefonoAlumno
            };
        }

        public void CambiarNombre(string asNuevoNombre)
        {
            NombreAlumno = asNuevoNombre;
        }
    }
}
