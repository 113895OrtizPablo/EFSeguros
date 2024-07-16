using System;
using System.Collections.Generic;

namespace Api.ModelsDataBase;

public partial class Asegurado
{
    public int Id { get; set; }

    public int Dni { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

    public int? PolizaId { get; set; }

    public string Estado { get; set; } = null!;

    public virtual Poliza? Poliza { get; set; }
}
