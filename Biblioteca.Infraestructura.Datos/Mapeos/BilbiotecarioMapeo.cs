using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infraestructura.Datos.Mapeos
{
    class BilbiotecarioMapeo : EntityTypeConfiguration<Bilbiotecario>
    {
            ToTable("TBL_BIBLIOTECARIO");
            HasKey(p => p.IdBibliotecario);
            Property(p => p.IdBibliotecario).HasColumnName("ID_BIBLIOTECARIO");
            Property(p => p.NombreBibliotecario).HasColumnName("NOM_BILBIOTECARIO");
            Property(p => p.ApellidoBibliotecario).HasColumnName("APE_BIBLIOTECARIO");
            Property(p => p.DireccionBibliotecario).HasColumnName("DIR_BIBLIOTECARIO");  

    }
}
