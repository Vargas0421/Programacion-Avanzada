using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.AccesoADatos.Cliente.ActualizarCliente
{
    public interface IActualizarClienteAD
    {
        int ActualizarCliente(ClienteDto elClienteParaGuardar);

    }
}
