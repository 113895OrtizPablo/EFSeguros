using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Models
{
    public class TipoDeProducto
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Tipo { get; set; }

        [MaxLength(50)]
        public string Descripcion { get; set; }
    }
}
