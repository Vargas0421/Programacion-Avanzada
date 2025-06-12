using MiPrimeraSolucion.AccesoADatoss.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatoss
{
    public class Contexto : DbContext
    {

        public Contexto()
        {
            Database.SetInitializer<Contexto>(null);
        }
        public DbSet<InventarioAD> Inventario { get; set; }
        public DbSet<ClienteAD> Cliente { get; set; }

    }
}
