using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Models
{
    public class Poliza
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ProductoId")]
        [Required]
        public Producto SuProducto { get; set; }

        [MaxLength(50)]
        [Required]
        public string Estado { get; set; }

        [MaxLength(100)]
        public string Descripcion { get; set; }

        public List<Asegurado> lAsegurados { get; set; }


        public Poliza()
        {
            lAsegurados = new List<Asegurado>();
        }


        public void AgregarAsegurado(Asegurado asegurado)
        {
            lAsegurados.Add(asegurado);
        }

        public void EliminarAsegurado(int id)
        {
            lAsegurados.RemoveAt(id);
        }

    }
}
