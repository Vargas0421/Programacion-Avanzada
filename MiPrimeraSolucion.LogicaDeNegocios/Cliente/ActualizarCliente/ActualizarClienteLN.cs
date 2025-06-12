using MiPrimeraSolucion.Abstracciones.AccesoADatos.Cliente.ActualizarCliente;
using MiPrimeraSolucion.Abstracciones.Comunes.Fecha;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Cliente.ActualizarCliente;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.AccesoADatoss.Cliente.ActualizarCliente;
using MiPrimeraSolucion.AccesoADatoss.Inventario.ActualizarInventario;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocios.Cliente.ActualizarCliente
{
    public class ActualizarClienteLN : IActualizarClienteLN
    {
        private readonly IActualizarClienteAD _actualizarClienteLN;
        private readonly IFechaLN _fecha;
        int zonaHoraria = 0; // Zona horaria UTC-3, ajustar según sea necesario 

        public ActualizarClienteLN()
        {
            _actualizarClienteLN = new ActualizarClienteAD();
            _fecha = new FechaLN();
            zonaHoraria = Convert.ToInt32(ConfigurationManager.AppSettings["zonaHoraria"]);
        }
        public int Actualizar(ClienteDto elClienteParaActualzar)
        {
            elClienteParaActualzar.fechaDeModificacion = _fecha.ObtenerFechaPorZonaHorario(zonaHoraria);
            int cantidadDeDatosAlmacenados = _actualizarClienteLN.ActualizarCliente(elClienteParaActualzar);
            return cantidadDeDatosAlmacenados;
        }
    }
}
