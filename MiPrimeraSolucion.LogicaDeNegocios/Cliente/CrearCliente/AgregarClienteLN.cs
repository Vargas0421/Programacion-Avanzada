using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.CrearInventario;
using MiPrimeraSolucion.Abstracciones.Comunes.Fecha;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Cliente.AgregarCliente;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.AgregarInventario;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.AccesoADatoss.Cliente.AgregarCliente;
using MiPrimeraSolucion.AccesoADatoss.Inventario.CrearInventario;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocios.Cliente.CrearCliente
{
    public class AgregarClienteLN : IAgregarClienteLN
    {
        private readonly IAgregarClienteLN _agregarClienteAD;
        private readonly IFechaLN _fecha;
        int zonaHoraria = 0; // Zona horaria UTC-3, ajustar según sea necesario
         

        public AgregarClienteLN()
        {
            _agregarClienteAD = new AgregarClienteAD();
            _fecha = new FechaLN();
            zonaHoraria = Convert.ToInt32(ConfigurationManager.AppSettings["zonaHoraria"]);
        }
        public async Task<int> Crear(ClienteDto elClientreParaGuardar)
        {
            elClientreParaGuardar.fechaDeRegistro = _fecha.ObtenerFechaPorZonaHorario(zonaHoraria);
            elClientreParaGuardar.estado = true; // Por defecto, el estado es verdadero (activo)
            int cantidadDeDatosAlmacenados = await _agregarClienteAD.Crear(elClientreParaGuardar);
            return cantidadDeDatosAlmacenados;
        }
    }

}
