using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos.Entity_Framework
{
    [Table("Estudiante")]
    public class Estudiante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Estudiante_id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(50)]
        public string Primer_apellido { get; set; }
        [StringLength(50)]
        public string Segundo_apellido { get; set; }
        public int Edad { get; set; }
    }
}
