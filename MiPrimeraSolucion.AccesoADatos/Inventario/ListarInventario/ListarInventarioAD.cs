using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ListarInventario;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatos.Inventario.ListarInventario
{
    public class ListarInventarioAD  : IListarInventarioLN
    {
        private Contexto _contexto; 

            public ListarInventarioAD(Contexto contexto)
        {
            _contexto = new Contexto();

        }

        public List<InventarioDto> Listar() { 

            List<InventarioDto> laListaDeRepuestos = (from inventario in _contexto.Inventario
                                                      select new InventarioDto
                                                      {
                                                          codigoDelRepuesto = inventario.codigoDelRepuesto,
                                                          nombreDelRepuesto = inventario.nombreDelRepuesto,
                                                          marcaDelRepuesto = inventario.marcaDelRepuesto,
                                                          vehiculo = inventario.vehiculo,
                                                          modelo = inventario.modelo,
                                                          anio = inventario.anio,
                                                          cantidad = inventario.cantidad,
                                                          fechaDeRegistro = inventario.fechaDeRegistro,
                                                          fechaDeModificacion = inventario.fechaDeModificacion,
                                                          estado = inventario.estado,
                                                          id = inventario.id    
                                                      }).ToList();
            return laListaDeRepuestos;

        }

    }
}
