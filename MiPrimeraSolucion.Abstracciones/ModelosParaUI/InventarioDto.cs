using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.ModelosParaUI
{
    public class InventarioDto
    {

        public int id { get; set; }
        [MinLength(2)]
        [MaxLength(4)]
        [Display(Name = "Codigo Repuesto")]
        [Required]
        public string codigoDelRepuesto { get; set; }
        [MinLength(4)]
        [Display(Name = "Nombre Repuesto")]
        [Required]
        public string nombreDelRepuesto { get; set; }
        [MinLength(4)]
        [Display(Name = "Marca Repuesto")]
        [Required]
        public string marcaDelRepuesto { get; set; }
        [MinLength(4)]
        [Display(Name = "Vehiculo")]
        [Required]
        public string vehiculo { get; set; }
        [MinLength(4)]
        [Display(Name = "Modelo del Vehiculo")]
        [Required]
        public string modelo { get; set; }
        [Range(1900, 2100, ErrorMessage = "El año debe estar entre 1900 y 2100")] // esto porque no se puede usar el miunlegth en int 
        [Display(Name = "Año del vehiculo")]
        [Required]
        public int anio { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0")]
        [Display(Name = "Cantidad del repuesto")]
        [Required]
        public int cantidad { get; set; }
        [Display(Name = "Fecha Registro")]
        [Required]
        public DateTime fechaDeRegistro { get; set; }
        [Display(Name = "Fecha Modificacion")]
        public DateTime? fechaDeModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool estado { get; set; }
    }
}
