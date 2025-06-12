using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ListarInventario;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.AccesoADatoss.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatoss.Inventario.ListarInventario
{
    public class ListarInventarioAD : IListarInventarioLN
    {

        private Contexto _contexto;
        public ListarInventarioAD()
        {
            _contexto = new Contexto();
        }

        public List<InventarioDto> Listar()
        {
           // List<InventarioAD> inventario = _contexto.Inventario.ToList();  
            List<InventarioDto> laListaDeRepuestos = (from inventario in _contexto.Inventario
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

                                                      }).ToList();
            return laListaDeRepuestos;



        }
    }
       
}
