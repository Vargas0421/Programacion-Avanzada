using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Cliente.ListarCliente;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.AccesoADatoss.Cliente.ListarCliente;
using MiPrimeraSolucion.AccesoADatoss.Inventario.ListarInventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocios.Cliente.ListarCliente
{
    public class ListarClienteLN: IListarClienteLN
    {
        private readonly ListarClienteAD _listarClienteAD; 
          
        public ListarClienteLN()
        { 
            _listarClienteAD = new ListarClienteAD(); 
        }
        public List<ClienteDto> Listar()
        {
            List<ClienteDto> elCliente = _listarClienteAD.Listar();
            return elCliente;
        }
    }
}
