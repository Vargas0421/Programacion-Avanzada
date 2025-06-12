using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatoss.Modelos
{
    [Table("CLIENTE")]

    public class ClienteAD
    {
        [Column("ID")]
        [Key]
        public int identificacion { get; set; }
        [Column("NOMBRE")]
        public string nombre { get; set; }
        [Column("PRIMER_APELLIDO")]
        public string primerApellido { get; set; }
        [Column("SEGUNDO_APELLIDO")]
        public string segundoApellido { get; set; }
        [Column("TELEFONO")]
        public int telefono { get; set; }
        [Column("CORREO")]
        public string correo { get; set; }
        [Column("DIRECCION")]
        public string direccion { get; set; }
        [Column("FECHA_DE_REGISTRO")]
        public DateTime fechaDeRegistro { get; set; }
        [Column("FECHA_DE_MODIFICACION")]
        public DateTime? fechaDeModificacion { get; set; }
        [Column("ESTADO")]
        public bool estado { get; set; }



    }
}
