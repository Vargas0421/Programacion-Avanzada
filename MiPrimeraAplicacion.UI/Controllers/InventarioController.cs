using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ActualizarInventario;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.AgregarInventario;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.EliminarInventario;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ListarInventario;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerInventarioPorId;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.LogicaDeNegocios.Inventario.AcutalizarInventario;
using MiPrimeraSolucion.LogicaDeNegocios.Inventario.CrearInventario;
using MiPrimeraSolucion.LogicaDeNegocios.Inventario.EliminarInventario;
using MiPrimeraSolucion.LogicaDeNegocios.Inventario.ListarInventario;
using MiPrimeraSolucion.LogicaDeNegocios.Inventario.ObtenerInventarioPorId;

namespace MiPrimeraAplicacion.UI.Controllers
{
    public class InventarioController : Controller
    {
        private readonly IListarInventarioLN _listarInventarioLN;
        private readonly ICrearInventarioLN _crearInventarioLN;
        private readonly IObetenerInventrioPorIdLN _obtenerInventarioPorIdLN;
        private readonly IEliminarInventarioLN _eliminarInventarioLN;
        private readonly IActualizarInventarioLN _actualizarInventarioLN;
        public InventarioController()
        {
            _listarInventarioLN = new ListarInventarioLN();
            _crearInventarioLN = new CrearInventarioLN();
            _obtenerInventarioPorIdLN = new ObetenerInventrioPorIdLN();
            _eliminarInventarioLN = new EliminarInventarioLN();
            _actualizarInventarioLN = new ActualizarInventarioLN();
        }
        public ActionResult ListarInventario()
        {
            List<InventarioDto> laListaDeInevntario = _listarInventarioLN.Listar();
            return View(laListaDeInevntario);
        }

        public ActionResult DetallesDelRepuesto (int id)
        {
            InventarioDto elIventario = _obtenerInventarioPorIdLN.Obtener(id);

            return View(elIventario);
        }

        // GET: Inventario/Create
        public ActionResult CrearRepusto()
        {
            return View();
        }

        // POST: Inventario/Create
        [HttpPost]
        public async Task<ActionResult> CrearRepusto(InventarioDto elInventarioParaGuardar)
        {
            try
            {
                // TODO: Add insert logic here
                int cantidadDeDatosAlmacenados = await _crearInventarioLN.Crear(elInventarioParaGuardar);
                return RedirectToAction("ListarInventario");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Edit/5
        public ActionResult EditarRepuesto(int id)
        {
            InventarioDto elIventario = _obtenerInventarioPorIdLN.Obtener(id);
            return View(elIventario);

        }

        // POST: Inventario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarRepuesto(InventarioDto inventarioActualizado) // se implementa el modelo binding para asignar los valores con un inventarioDto
        {
            if (!ModelState.IsValid)
            {
                return View("ListarInventario"); // Muestra de nuevo la vista con errores
            }

            try
            {
                _actualizarInventarioLN.Actualizar(inventarioActualizado);
                return RedirectToAction("ListarInventario");
            }
            catch
            {
                return View(inventarioActualizado);
            }
        }


        // GET: Inventario/Delete/5 
        public ActionResult EliminarRepuesto(int id)
        {
            InventarioDto elIventario = _obtenerInventarioPorIdLN.Obtener(id);
            return View(elIventario);
        }

        // POST: Inventario/Delete/5
        [HttpPost]
        public ActionResult EliminarRepuesto(int id, FormCollection collection)
        {
            try
            {
                InventarioDto inventarioAEliminar = _obtenerInventarioPorIdLN.Obtener(id);
                if (inventarioAEliminar == null)
                {
                    return HttpNotFound();
                }

                _eliminarInventarioLN.Eliminar(inventarioAEliminar);

                return RedirectToAction("ListarInventario"); // Vista de confirmación

            }
            catch
            {
                return View();
            }
        }
    }
}
