using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.CrearInventario;
using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.EliminarInventairo;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.EliminarInventario;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.AccesoADatoss.Inventario.EliminarInventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocios.Inventario.EliminarInventario
{
    public class EliminarInventarioLN : IEliminarInventarioLN
    {
        private readonly IEliminarInventarioAD _eliminarInventarioAD;

        public EliminarInventarioLN()
        {
            _eliminarInventarioAD = new EliminarInventarioAD();
        }

        public int Eliminar(InventarioDto elInventaroAEliminar)
        {
            int cantidadDeDatosEliminados = _eliminarInventarioAD.Eliminar(elInventaroAEliminar.id);
            return cantidadDeDatosEliminados;
        }


    }
}
