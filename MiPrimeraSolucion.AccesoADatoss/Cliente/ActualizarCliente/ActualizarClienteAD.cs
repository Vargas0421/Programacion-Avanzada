using MiPrimeraSolucion.Abstracciones.AccesoADatos.Cliente.ActualizarCliente;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.AccesoADatoss.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatoss.Cliente.ActualizarCliente
{
    public class ActualizarClienteAD : IActualizarClienteAD
    {

        private Contexto _contexto;
        public ActualizarClienteAD()
        {
            _contexto = new Contexto();
        }
        public int ActualizarCliente(ClienteDto elClienteParaGuardar)
        {

            int cantidadDeDatosAlmacenados = 0;
            ClienteAD elClienteEnBaseDeDatos = _contexto.Cliente.Where(cliente => cliente.identificacion == elClienteParaGuardar.identificacion).FirstOrDefault();
            if (elClienteEnBaseDeDatos != null)
            {
                elClienteEnBaseDeDatos.fechaDeModificacion = elClienteParaGuardar.fechaDeModificacion;
                elClienteEnBaseDeDatos.nombre = elClienteParaGuardar.nombre;
                elClienteEnBaseDeDatos.primerApellido = elClienteParaGuardar.primerApellido;
                elClienteEnBaseDeDatos.segundoApellido = elClienteParaGuardar.segundoApellido;
                elClienteEnBaseDeDatos.telefono = elClienteParaGuardar.telefono;
                elClienteEnBaseDeDatos.correo = elClienteParaGuardar.correo;
                elClienteEnBaseDeDatos.direccion = elClienteParaGuardar.direccion;
                elClienteEnBaseDeDatos.estado = elClienteParaGuardar.estado;
                cantidadDeDatosAlmacenados = _contexto.SaveChanges();
            }
            return cantidadDeDatosAlmacenados;

        }
    }
}
