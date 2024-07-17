using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ModelsCodeFirst
{
    public class Poliza
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ProductoId")]
        [Required]
        public int ProductoId { get; set; }

        public Producto SuProducto { get; set; }

        [MaxLength(50)]
        [Required]
        public string Estado { get; set; }

        public List<Asegurado> lAsegurados { get; set; }


    }
}
