using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.Comunes.Fecha
{
    public class FechaLN: IFechaLN
    {
        public DateTime ObtenerFechaPorZonaHorario(int cantidadDeHoras)
        {
            return DateTime.UtcNow.AddHours(cantidadDeHoras);
        }

    }
}
