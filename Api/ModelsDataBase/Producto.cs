using System;
using System.Collections.Generic;

namespace Api.ModelsDataBase;

public partial class Producto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int TipoId { get; set; }

    public virtual ICollection<Poliza> Polizas { get; set; } = new List<Poliza>();

    public virtual TipoProducto Tipo { get; set; } = null!;
}
