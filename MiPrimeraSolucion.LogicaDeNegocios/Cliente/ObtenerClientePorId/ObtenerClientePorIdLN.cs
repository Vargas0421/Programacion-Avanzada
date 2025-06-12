using MiPrimeraSolucion.Abstracciones.AccesoADatos.Cliente.ObtenerClientePorId;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Cliente.ObtenerClientePorId;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.AccesoADatoss.Cliente.ObtenerClientePorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocios.Cliente.ObtenerClientePorId
{
    public class ObtenerClientePorIdLN : IObtenerClientePorIdLN
    {
        private readonly IObtenerClientePorIdAD _obtenerClientePorIdAD;
        public ObtenerClientePorIdLN()
        {
            _obtenerClientePorIdAD = new ObtenerClientePorIdAD();
        }
        public ClienteDto Obtener(int id)
        {
            ClienteDto elCliente = _obtenerClientePorIdAD.Obtener(id);
            return elCliente;
        }
    }
}
