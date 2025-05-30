using System;
using System.Collections.Generic;

namespace DbFirstWebApp.Models;

public partial class Divtbl
{
    public string Division { get; set; } = null!;

    public string? Names { get; set; }

    // 자식으로 Bookstbl을 가지고 있다.
    public virtual ICollection<Bookstbl> Bookstbls { get; set; } = new List<Bookstbl>();
}
