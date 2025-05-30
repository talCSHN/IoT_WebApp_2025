using System;
using System.Collections.Generic;

namespace DBFirstWebApp.Models;

public partial class Bookstbl
{
    public int Idx { get; set; }

    public string? Author { get; set; }

    public string Division { get; set; } = null!;

    public string? Names { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public string? Isbn { get; set; }

    public decimal? Price { get; set; }

    // 부모
    public virtual Divtbl DivisionNavigation { get; set; } = null!;
    // 자식
    public virtual ICollection<Rentaltbl> Rentaltbls { get; set; } = new List<Rentaltbl>();
}
