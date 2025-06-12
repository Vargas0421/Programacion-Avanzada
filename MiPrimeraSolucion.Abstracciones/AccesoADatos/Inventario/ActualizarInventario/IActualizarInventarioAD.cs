using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ActualizarInventario
{
    public  interface IActualizarInventarioAD
    {
        int ActualizarInventario(InventarioDto elInventarioParaGuardar);
    }
}
