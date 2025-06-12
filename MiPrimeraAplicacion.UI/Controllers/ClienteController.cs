using MiPrimeraSolucion.Abstracciones.AccesoADatos.Cliente.ActualizarCliente;
using MiPrimeraSolucion.Abstracciones.AccesoADatos.Cliente.ObtenerClientePorId;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Cliente.AgregarCliente;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Cliente.ListarCliente;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Cliente.ObtenerClientePorId;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.LogicaDeNegocios.Cliente.ActualizarCliente;
using MiPrimeraSolucion.LogicaDeNegocios.Cliente.CrearCliente;
using MiPrimeraSolucion.LogicaDeNegocios.Cliente.EliminarCliente;
using MiPrimeraSolucion.LogicaDeNegocios.Cliente.ListarCliente;
using MiPrimeraSolucion.LogicaDeNegocios.Cliente.ObtenerClientePorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace MiPrimeraAplicacion.UI.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IListarClienteLN _listarClienteLN;
        private readonly IAgregarClienteLN _agregarClienteLN;
        private readonly IObtenerClientePorIdLN _obtenerclientePorIdLN;
        private readonly ActualizarClienteLN _actualizarClienteLN;
        private readonly EliminarClienteLN _eliminarClienteLN;

        public ClienteController()
        {
            _listarClienteLN = new ListarClienteLN();
            _agregarClienteLN = new AgregarClienteLN();
            _obtenerclientePorIdLN = new ObtenerClientePorIdLN();
            _actualizarClienteLN = new ActualizarClienteLN();
            _eliminarClienteLN = new EliminarClienteLN();
        }
        // GET: Cliente 
        public ActionResult ListarCliente()
        {
            List<ClienteDto> laListaDeClientes = _listarClienteLN.Listar();
            return View(laListaDeClientes);
        }

        // GET: Cliente/Details/5
        public ActionResult DetalleCliente(int id)
        {
            ClienteDto elCliente = _obtenerclientePorIdLN.Obtener(id);
            return View(elCliente);

        }

        // GET: Cliente/Create
        public ActionResult CrearCliente()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public async Task<ActionResult> CrearCliente(ClienteDto elClienteParaGuardar)
        {
            try
            {
                int cantidadDeDatosAlmacenados = await _agregarClienteLN.Crear(elClienteParaGuardar);
                return RedirectToAction("ListarCliente");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult EditarCliente(int id)
        {
            ClienteDto elClienteParaActualizar = _obtenerclientePorIdLN.Obtener(id);
            return View(elClienteParaActualizar);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult EditarCliente(ClienteDto elClienteParaActualizar)
        {
            if (!ModelState.IsValid)
            {
                return View("ListarCliente"); // Muestra de nuevo la vista con errores
            }
            try
            {
                _actualizarClienteLN.Actualizar(elClienteParaActualizar);
                return RedirectToAction("ListarCliente");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult EliminarCliente(int id)
        {
            ClienteDto elClienteDto = _obtenerclientePorIdLN.Obtener(id);
            return View(elClienteDto);
        }
            // POST: Cliente/Delete/5
            [HttpPost]
        public ActionResult EliminarCliente(int id, FormCollection collection)
        {
            try
            {
                ClienteDto clienteAEliminar = _obtenerclientePorIdLN.Obtener(id);
                if (clienteAEliminar == null)
                {
                    return HttpNotFound();
                }

                _eliminarClienteLN.Eliminar(clienteAEliminar);
                return RedirectToAction("ListarCliente");
            }
            catch
            {
                return View();
            }
        }
    }
}
