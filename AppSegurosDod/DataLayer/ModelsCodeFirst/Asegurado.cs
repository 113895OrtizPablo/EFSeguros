using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ModelsCodeFirst
{
    public class Asegurado
    {
        [Key]
        public Guid Id { get; set; }


        [Required]
        [MaxLength(9)]
        public int DNI { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime FechaNacimiento { get; set; }

        [MaxLength(50)]
        [Required]
        public string Estado { get; set; }

        [ForeignKey("PolizaId")]
        [Required]
        public int PolizaId { get; set; }

        public Poliza SuPoliza { get; set; }
    }
}
