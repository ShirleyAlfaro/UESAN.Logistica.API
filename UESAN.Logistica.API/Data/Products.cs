﻿using System;
using System.Collections.Generic;

namespace UESAN.Logistica.API.Data;

public partial class Products
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public decimal? UnitPrice { get; set; }
}
