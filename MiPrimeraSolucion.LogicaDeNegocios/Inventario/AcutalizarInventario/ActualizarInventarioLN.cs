using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ActualizarInventario;
using MiPrimeraSolucion.Abstracciones.Comunes.Fecha;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ActualizarInventario;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.AccesoADatoss.Inventario.ActualizarInventario;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocios.Inventario.AcutalizarInventario
{
    public class ActualizarInventarioLN: IActualizarInventarioLN
    {
        private readonly IActualizarInventarioAD _actualizarInventarioLN;
        private readonly IFechaLN _fecha;
        int zonaHoraria = 0; // Zona horaria UTC-3, ajustar según sea necesario

        public ActualizarInventarioLN()
        {
            _actualizarInventarioLN = new ActualizarInventarioAD();
            _fecha = new FechaLN();
            zonaHoraria = Convert.ToInt32(ConfigurationManager.AppSettings["zonaHoraria"]);
        }
        public int Actualizar(InventarioDto elInventarioParaActualizar)
        {
            elInventarioParaActualizar.fechaDeModificacion = _fecha.ObtenerFechaPorZonaHorario(zonaHoraria);
            int cantidadDeDatosAlmacenados = _actualizarInventarioLN.ActualizarInventario(elInventarioParaActualizar);
            return cantidadDeDatosAlmacenados;
        }
    }
}
