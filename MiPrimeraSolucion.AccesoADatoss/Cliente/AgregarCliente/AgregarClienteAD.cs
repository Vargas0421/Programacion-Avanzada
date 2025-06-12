using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Cliente.AgregarCliente;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using MiPrimeraSolucion.AccesoADatoss.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatoss.Cliente.AgregarCliente
{
    public class AgregarClienteAD : IAgregarClienteLN
    {
        private Contexto _contexto;
        public AgregarClienteAD()
        {
            _contexto = new Contexto();
        }
        public async Task<int> Crear(ClienteDto elClienteParaGuardar)
        {
            ClienteAD elClienteAGuardar = ConvertirObjeto(elClienteParaGuardar);
            _contexto.Cliente.Add(elClienteAGuardar); //addRange para cunado s emanda una lsta 
            int cantidadDeDatosAlmacenados = await _contexto.SaveChangesAsync(); // await porque es un metodo asincrono 

            return cantidadDeDatosAlmacenados;

        }
        private ClienteAD ConvertirObjeto(ClienteDto elClienteParaGuardar)
        {
            return new ClienteAD
            {
                identificacion = elClienteParaGuardar.identificacion,
                nombre = elClienteParaGuardar.nombre,
                primerApellido = elClienteParaGuardar.primerApellido,
                segundoApellido = elClienteParaGuardar.segundoApellido,
                telefono = elClienteParaGuardar.telefono,
                correo = elClienteParaGuardar.correo,
                direccion = elClienteParaGuardar.direccion,
                fechaDeRegistro = elClienteParaGuardar.fechaDeRegistro,
                fechaDeModificacion = elClienteParaGuardar.fechaDeModificacion,
                estado = elClienteParaGuardar.estado
            };
            // el; id no se guarda porque viene de la base de datos y no se debe asignar manualmente
        }
    }
}
