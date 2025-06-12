using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.Comunes.Fecha
{
    public interface IFechaLN
    {
        DateTime ObtenerFechaPorZonaHorario(int cantidadDeHoras);
    }
}
