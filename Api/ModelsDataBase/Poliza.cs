using System;
using System.Collections.Generic;

namespace Api.ModelsDataBase;

public partial class Poliza
{
    public int Id { get; set; }

    public int ProductoId { get; set; }

    public string Estado { get; set; } = null!;

    public virtual ICollection<Asegurado> Asegurados { get; set; } = new List<Asegurado>();

    public virtual Producto Producto { get; set; } = null!;
}
