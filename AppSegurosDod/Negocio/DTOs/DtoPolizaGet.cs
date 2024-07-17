using DataLayer.ModelsCodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.DTOs
{
    public class DtoPolizaGet
    {
        public int Id { get; set; }

        public string Producto { get; set; }

        public string Estado { get; set; }

        public List<DtoAseguradoGetPoliza> lAsegurados { get; set; }
    }
}
