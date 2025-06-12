using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.AccesoADatos.Cliente.ObtenerClientePorId
{
    public interface IObtenerClientePorIdAD
    {
        ClienteDto Obtener(int id);
    }
}
