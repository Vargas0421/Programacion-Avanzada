using MiPrimeraSolucion.Abstracciones.Comunes.Fecha;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ListarInventario;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiPrimeraSolucion.AccesoADatoss.Inventario.ListarInventario;

namespace MiPrimeraSolucion.LogicaDeNegocios.Inventario.ListarInventario  
{
    public class ListarInventarioLN : IListarInventarioLN
    {

        private readonly ListarInventarioAD _listarInventarioAD;
       // private readonly IFechaLN _fechaLN

        public ListarInventarioLN()
        {
        _listarInventarioAD = new ListarInventarioAD();
        }
        public List<InventarioDto> Listar()
        {
            List<InventarioDto> elInventario = _listarInventarioAD.Listar();
            return elInventario;
        }

    }
}
