using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.AgregarInventario
{
    public interface ICrearInventarioLN
    {
        Task<int> Crear(InventarioDto elInventarioParaGuardar);
    }
}
