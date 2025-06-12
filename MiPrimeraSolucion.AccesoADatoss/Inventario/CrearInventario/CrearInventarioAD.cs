using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.CrearInventario;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.AccesoADatoss.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatoss.Inventario.CrearInventario
{
    public class CrearInventarioAD : ICrearInventarioAD
    {
        private Contexto _contexto;
        public CrearInventarioAD()
        {
            _contexto = new Contexto(); 
        }

        public async Task<int> Crear(InventarioDto elInventarioParaGuardar)
        {
            //InventarioAD elInventarioEnBaseDeDatos = _contexto.Inventario.Where(inventario => inventario.id == elInventarioParaGuardar.id).FirstOrDefault();
            InventarioAD elInventarioAGuardar = ConvertirObjeto(elInventarioParaGuardar);
            _contexto.Inventario.Add(elInventarioAGuardar); //addRange para cunado s emanda una lsta 
            int cantidadDeDatosAlmacenados = await _contexto.SaveChangesAsync(); // await porque es un metodo asincrono 

            return cantidadDeDatosAlmacenados;

        }

        private InventarioAD ConvertirObjeto(InventarioDto elInventarioParaGuardar)
        {
            return new InventarioAD
            {
                anio = elInventarioParaGuardar.anio,
                cantidad = elInventarioParaGuardar.cantidad,
                codigoDelRepuesto = elInventarioParaGuardar.codigoDelRepuesto,
                estado = elInventarioParaGuardar.estado,
                fechaDeModificacion = elInventarioParaGuardar.fechaDeModificacion,
                fechaDeRegistro = elInventarioParaGuardar.fechaDeRegistro,
                marcaDelRepuesto = elInventarioParaGuardar.marcaDelRepuesto,
                modelo = elInventarioParaGuardar.modelo,
                nombreDelRepuesto = elInventarioParaGuardar.nombreDelRepuesto,
                vehiculo = elInventarioParaGuardar.vehiculo
                // el; id no se guarda porque viene de la base de datos y no se debe asignar manualmente
            };
        }
    }
}
