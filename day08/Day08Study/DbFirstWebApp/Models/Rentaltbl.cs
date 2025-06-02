using System;
using System.Collections.Generic;

namespace DbFirstWebApp.Models;

public partial class Rentaltbl
{
    public int Idx { get; set; }

    public int MemberIdx { get; set; }

    public int BookIdx { get; set; }

    public DateTime? RentalDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    // 부모 Bookstbl 연결
    public virtual Bookstbl BookIdxNavigation { get; set; } = null!;

    // 부모 Membertbl 연결
    public virtual Membertbl MemberIdxNavigation { get; set; } = null!;
}
