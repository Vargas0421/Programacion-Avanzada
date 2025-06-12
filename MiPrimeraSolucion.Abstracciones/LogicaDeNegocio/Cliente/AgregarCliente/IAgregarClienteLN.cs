using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Cliente.AgregarCliente
{
    public interface IAgregarClienteLN
    {
        Task<int> Crear(ClienteDto elClienteParaGuardar);

    }
}
