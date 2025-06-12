using MiPrimeraSolucion.Abstracciones.AccesoADatos.Cliente.EliminarCliente;
using MiPrimeraSolucion.AccesoADatoss.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatoss.Cliente.EliminarCliente
{
    public class EliminarClienteAD : IEliminarClienteAD
    {

        private Contexto _contexto;
        public EliminarClienteAD()
        {
            _contexto = new Contexto();
        }

        public int Eliminar(int id)
        {
            int cantidadDeDatosAlmacenados = 0;
            ClienteAD elClienteEnBaseDeDAtos = _contexto.Cliente.Where(cliente => cliente.identificacion == id).FirstOrDefault();
            if (elClienteEnBaseDeDAtos != null)
            {
                _contexto.Cliente.Remove(elClienteEnBaseDeDAtos); // Elimina el inventario encontrado
                cantidadDeDatosAlmacenados = _contexto.SaveChanges(); // No se encontró el inventario, no se actualiza nada
            }

            return cantidadDeDatosAlmacenados;

        }
    }
}
