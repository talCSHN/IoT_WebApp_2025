using System;
using System.Collections.Generic;

namespace DbFirstWebApp.Models;

public partial class Membertbl
{
    public int Idx { get; set; }

    public string Names { get; set; } = null!;

    public string? Levels { get; set; }

    public string? Addr { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Rentaltbl> Rentaltbls { get; set; } = new List<Rentaltbl>();
}
