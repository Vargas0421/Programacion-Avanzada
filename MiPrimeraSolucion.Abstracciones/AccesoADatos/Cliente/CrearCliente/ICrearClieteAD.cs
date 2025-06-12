using MiPrimeraSolucion.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.AccesoADatos.Cliente.CrearCliente
{
    public interface ICrearClieteAD
    {
        Task<int> Crear(ClienteDto elClienteParaGuardar);

    }
}
