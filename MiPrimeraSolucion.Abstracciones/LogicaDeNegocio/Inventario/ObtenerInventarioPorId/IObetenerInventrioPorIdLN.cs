using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerInventarioPorId
{
    public interface IObetenerInventrioPorIdLN
    {
        InventarioDto Obtener(int id);
    }
}
