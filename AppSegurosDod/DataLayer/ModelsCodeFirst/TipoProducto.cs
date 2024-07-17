using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ModelsCodeFirst
{
    public class TipoProducto
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Tipo { get; set; }


        public List<Producto> lProductos { get; set; }

    }
}
