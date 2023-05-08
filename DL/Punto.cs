using System;
using System.Collections.Generic;

namespace DL;

public partial class Punto
{
    public int IdPunto { get; set; }

    public string? Nombre { get; set; }

    public string? Latitud { get; set; }

    public string? Longitud { get; set; }

    public DateTime? FechaHora { get; set; }
}
