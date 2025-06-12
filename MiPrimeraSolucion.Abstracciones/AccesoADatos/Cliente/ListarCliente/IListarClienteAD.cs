using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.AccesoADatos.Cliente.ListarCliente
{
    internal interface IListarClienteAD
    {
        List<ClienteDto> Listar();

    }
}
