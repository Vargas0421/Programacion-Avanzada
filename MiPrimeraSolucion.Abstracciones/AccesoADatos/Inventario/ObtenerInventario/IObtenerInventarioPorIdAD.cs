using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ObtenerInventario
{
    public  interface IObtenerInventarioPorIdAD
    {
        InventarioDto Obtener(int id);
    }
}
