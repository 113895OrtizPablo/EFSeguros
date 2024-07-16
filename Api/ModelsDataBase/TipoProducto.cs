using System;
using System.Collections.Generic;

namespace Api.ModelsDataBase;

public partial class TipoProducto
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
