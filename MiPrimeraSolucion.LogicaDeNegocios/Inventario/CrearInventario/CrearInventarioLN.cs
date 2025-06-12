using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.CrearInventario;
using MiPrimeraSolucion.Abstracciones.Comunes.Fecha;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.AccesoADatoss.Inventario.CrearInventario;
using System.Threading;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.AgregarInventario;

namespace MiPrimeraSolucion.LogicaDeNegocios.Inventario.CrearInventario
{
    public class CrearInventarioLN : ICrearInventarioLN
    {
        private readonly ICrearInventarioAD _crearInventarioAD;
        private readonly IFechaLN _fecha;
        int zonaHoraria = 0; // Zona horaria UTC-3, ajustar según sea necesario

        public CrearInventarioLN()
        {
            _crearInventarioAD = new CrearInventarioAD();
            _fecha = new FechaLN();
            zonaHoraria = Convert.ToInt32(ConfigurationManager.AppSettings["zonaHoraria"]);


        }
        public async Task<int> Crear(InventarioDto elInventarioParaGuardar)
        {
            elInventarioParaGuardar.fechaDeRegistro = _fecha.ObtenerFechaPorZonaHorario(zonaHoraria);
            elInventarioParaGuardar.estado = true; // Por defecto, el estado es verdadero (activo)
            int cantidadDeDatosAlmacenados = await _crearInventarioAD.Crear(elInventarioParaGuardar);
            return cantidadDeDatosAlmacenados;  
        }
    }
}
