using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ActualizarInventario;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.AccesoADatoss.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatoss.Inventario.ActualizarInventario
{
    public class ActualizarInventarioAD : IActualizarInventarioAD
    {
        private Contexto _contexto; 
        public ActualizarInventarioAD()
        {
            _contexto = new Contexto();
        }

        public int ActualizarInventario(InventarioDto elInventarioParaGuardar)
        {
            int cantidadDeDatosAlmacenados = 0;
            InventarioAD elInventarioEnBaseDeDatos = _contexto.Inventario.Where(inventario => inventario.id == elInventarioParaGuardar.id).FirstOrDefault();
            if(elInventarioEnBaseDeDatos != null){
                elInventarioEnBaseDeDatos.fechaDeModificacion = elInventarioParaGuardar.fechaDeModificacion;
                elInventarioEnBaseDeDatos.codigoDelRepuesto = elInventarioParaGuardar.codigoDelRepuesto;
                elInventarioEnBaseDeDatos.nombreDelRepuesto = elInventarioParaGuardar.nombreDelRepuesto;
                elInventarioEnBaseDeDatos.marcaDelRepuesto = elInventarioParaGuardar.marcaDelRepuesto;
                elInventarioEnBaseDeDatos.vehiculo = elInventarioParaGuardar.vehiculo;
                elInventarioEnBaseDeDatos.modelo = elInventarioParaGuardar.modelo;
                elInventarioEnBaseDeDatos.anio = elInventarioParaGuardar.anio;
                elInventarioEnBaseDeDatos.cantidad = elInventarioParaGuardar.cantidad;
                elInventarioEnBaseDeDatos.estado = elInventarioParaGuardar.estado;
                cantidadDeDatosAlmacenados = _contexto.SaveChanges(); // No se encontró el inventario, no se actualiza nada
            }

            return cantidadDeDatosAlmacenados;

        }

       
    }
}
