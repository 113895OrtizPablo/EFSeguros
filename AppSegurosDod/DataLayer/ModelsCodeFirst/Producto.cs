using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ModelsCodeFirst
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [ForeignKey("TipoProductoId")]
        [Required]
        public int TipoId { get; set; }

        public TipoProducto Tipo { get; set; }

        public List<Poliza> lPolizas { get; set; }
    }
}
