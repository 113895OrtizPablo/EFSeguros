using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.DTOs
{
    public class DtoAseguradoGetPoliza
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        public string Estado { get; set; }
    }
}
