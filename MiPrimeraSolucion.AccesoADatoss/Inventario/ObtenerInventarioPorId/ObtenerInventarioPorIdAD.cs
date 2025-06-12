using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ObtenerInventario;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatoss.Inventario.ObtenerInventarioPorId
{
    public class ObtenerInventarioPorIdAD : IObtenerInventarioPorIdAD
    {
        private Contexto _contexto;
        public ObtenerInventarioPorIdAD()
        {
            _contexto = new Contexto();
        }

        public InventarioDto Obtener(int id)
        {
            InventarioDto laListaDeRepuestos = (from inventario in _contexto.Inventario
                                                where inventario.id == id
                                                select new InventarioDto
                                                      {
                                                          anio = inventario.anio,
                                                          cantidad = inventario.cantidad,
                                                          codigoDelRepuesto = inventario.codigoDelRepuesto,
                                                          estado = inventario.estado,
                                                          fechaDeModificacion = inventario.fechaDeModificacion,
                                                          fechaDeRegistro = inventario.fechaDeRegistro,
                                                          marcaDelRepuesto = inventario.marcaDelRepuesto,
                                                          modelo = inventario.modelo,
                                                          nombreDelRepuesto = inventario.nombreDelRepuesto,
                                                          vehiculo = inventario.vehiculo,
                                                          id = inventario.id

                                                      }).FirstOrDefault();
            return laListaDeRepuestos;



        }

    }
}
