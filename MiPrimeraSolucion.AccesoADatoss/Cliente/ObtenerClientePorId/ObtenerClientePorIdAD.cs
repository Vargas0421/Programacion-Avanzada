using MiPrimeraSolucion.Abstracciones.AccesoADatos.Cliente.ObtenerClientePorId;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatoss.Cliente.ObtenerClientePorId
{
    public class ObtenerClientePorIdAD : IObtenerClientePorIdAD
    {
        private Contexto _contexto;
        public ObtenerClientePorIdAD()
        {
            _contexto = new Contexto();
        }

        public ClienteDto Obtener(int id)
        {
            ClienteDto laListaDeCliente = (from cliente in _contexto.Cliente
                                           where cliente.identificacion == id
                                           select new ClienteDto
                                           {
                                               nombre = cliente.nombre,
                                               primerApellido = cliente.primerApellido,
                                               segundoApellido = cliente.segundoApellido,
                                               telefono = cliente.telefono,
                                               correo = cliente.correo,
                                               direccion = cliente.direccion,
                                               fechaDeModificacion = cliente.fechaDeModificacion,
                                               fechaDeRegistro = cliente.fechaDeRegistro,
                                               estado = cliente.estado,
                                               identificacion = cliente.identificacion,

                                           }).FirstOrDefault();
            return laListaDeCliente;

        }
    }
}
