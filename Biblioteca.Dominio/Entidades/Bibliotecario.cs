using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Entidades
{
    class Bibliotecario
    {
        public int IdBibliotecario { get; set; }
        public string Nombrebibliotecario { get; private set; }
        public string Apellidobibliotecario { get; private set; }
        public string Direccionbibliotecario { get; private set; }

        public Bibliotecario Biliotecario
        {
            get => default(Bibliotecario);
            set
            {
            }
        }
    }
}
