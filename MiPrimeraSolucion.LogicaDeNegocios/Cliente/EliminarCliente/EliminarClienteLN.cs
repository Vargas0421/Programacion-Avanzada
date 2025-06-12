using MiPrimeraSolucion.Abstracciones.AccesoADatos.Cliente.EliminarCliente;
using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.EliminarInventairo;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Cliente.EliminarCliente;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.AccesoADatoss.Cliente.EliminarCliente;
using MiPrimeraSolucion.AccesoADatoss.Inventario.EliminarInventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocios.Cliente.EliminarCliente
{
    public class EliminarClienteLN : IEliminarClienteLN
    {
        private readonly  IEliminarClienteAD _eliminarClienteAD;

        public EliminarClienteLN()
        {
            _eliminarClienteAD = new EliminarClienteAD();
        }

        public int Eliminar(ClienteDto elClienteAEliminar)
        {
            int cantidadDeDatosEliminados = _eliminarClienteAD.Eliminar(elClienteAEliminar.identificacion);
            return cantidadDeDatosEliminados;
        }
    }
}
