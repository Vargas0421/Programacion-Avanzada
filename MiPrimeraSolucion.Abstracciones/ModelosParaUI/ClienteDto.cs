using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.ModelosParaUI
{
    public class ClienteDto
    {
        [Display(Name = " Identificacion del Cliente")]
        [Required]
        public int identificacion { get; set; }
        [MinLength(2)]
        [MaxLength(32)]
        [Display(Name = " Nombre del Cliente")]
        [Required]
        public string nombre { get; set; }
        [MinLength(2)]
        [MaxLength(32)]
        [Display(Name = " Primer Apellido del Cliente")]
        [Required]
        public string primerApellido { get; set; }
        [MinLength(2)]
        [MaxLength(32)]
        [Display(Name = " Segundo Apellido del Cliente")]
        public string segundoApellido { get; set; }
        [Display(Name = "Número del Cliente")]
        [Required(ErrorMessage = "El número de teléfono es obligatorio.")]
        [Range(00000000, 99999999, ErrorMessage = "El número debe tener exactamente 8 dígitos.")]
        public int telefono { get; set; }
        [MinLength(4)]
        [MaxLength(255)]
        [Display(Name = " Correo electronico del Cliente")]
        [Required]
        public string correo { get; set; }
        [MinLength(4)]
        [MaxLength(255)]
        [Display(Name = " Direccion del Cliente")]
        [Required]
        public string direccion { get; set; }
        [Display(Name = "Fecha Registro")]
        public DateTime fechaDeRegistro { get; set; }
        [Display(Name = "Fecha Modificacion")]

        public DateTime? fechaDeModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool estado { get; set; }
    }
}
