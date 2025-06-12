using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Cliente.ListarCliente;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatoss.Cliente.ListarCliente
{
    public class ListarClienteAD: IListarClienteLN
    {
        private Contexto _contexto;
        public ListarClienteAD()
        {
            _contexto = new Contexto();
        }
        public List<ClienteDto> Listar()
        {
            List<ClienteDto> laListaDeClientes = (from cliente in _contexto.Cliente
                                                      select new ClienteDto
                                                      {
                                                          identificacion = cliente.identificacion,
                                                          nombre = cliente.nombre,
                                                          primerApellido = cliente.primerApellido,
                                                          segundoApellido = cliente.segundoApellido,
                                                          telefono = cliente.telefono,
                                                          correo = cliente.correo,
                                                            direccion = cliente.direccion,
                                                            estado = cliente.estado,
                                                          fechaDeRegistro = cliente.fechaDeRegistro,
                                                          fechaDeModificacion = cliente.fechaDeModificacion
                                                      }).ToList();

            return laListaDeClientes;
        }

    }
}
