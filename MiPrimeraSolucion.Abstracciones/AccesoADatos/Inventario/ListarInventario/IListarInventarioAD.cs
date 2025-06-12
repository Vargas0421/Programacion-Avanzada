using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ListarInventario
{
    internal interface IListarInventarioAD
    {
        List<InventarioDto> Listar();   
    }
}
