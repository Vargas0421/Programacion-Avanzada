using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ObtenerInventario;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerInventarioPorId;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.AccesoADatoss.Inventario.ListarInventario;
using MiPrimeraSolucion.AccesoADatoss.Inventario.ObtenerInventarioPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocios.Inventario.ObtenerInventarioPorId 
{
    public class ObetenerInventrioPorIdLN: IObetenerInventrioPorIdLN
    {
        private readonly IObtenerInventarioPorIdAD _ObtenerInventarioPorIdAD;

        public ObetenerInventrioPorIdLN()
        {
            _ObtenerInventarioPorIdAD = new ObtenerInventarioPorIdAD();
        }
        public InventarioDto Obtener(int id)
        {
            InventarioDto elInventario = _ObtenerInventarioPorIdAD.Obtener(id);
            return elInventario;
        }
    }
}
