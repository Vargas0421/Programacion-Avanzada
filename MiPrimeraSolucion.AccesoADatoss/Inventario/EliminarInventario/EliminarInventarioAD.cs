using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.EliminarInventairo;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.AccesoADatoss.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatoss.Inventario.EliminarInventario
{
    public class EliminarInventarioAD : IEliminarInventarioAD
    {
        private Contexto _contexto;
        public EliminarInventarioAD()
        {
            _contexto = new Contexto();
        }

        public int Eliminar(int id)
        {
            int cantidadDeDatosAlmacenados = 0;
            InventarioAD elInventarioEnBaseDeDatos = _contexto.Inventario.Where(inventario => inventario.id == id).FirstOrDefault();
            if (elInventarioEnBaseDeDatos != null)
            {
               _contexto.Inventario.Remove(elInventarioEnBaseDeDatos); // Elimina el inventario encontrado
                cantidadDeDatosAlmacenados = _contexto.SaveChanges(); // No se encontró el inventario, no se actualiza nada
            }

            return cantidadDeDatosAlmacenados;

        }
    }
}
