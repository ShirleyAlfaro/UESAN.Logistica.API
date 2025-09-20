using System;
using System.Collections.Generic;

namespace UESAN.Logistica.API.Data;

public partial class Categoria
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }
}
