﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Entidades
{
    public class Reserva
    {
        public int IdReserva { get; private set; }
        public int IdAlumno { get; private set; }
        public DateTime FechaReserva { get; private set; }
        public int IdLibro { get; private set; }        
        public Libro LibroReservado { get; private set; }        
        public string EstadoReserva { get; private set; }

        public Libro Libro
        {
            get => default(Libro);
            set
            {
            }
        }
    }
}
