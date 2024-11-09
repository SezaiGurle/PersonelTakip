using System;
using System.Collections.Generic;

namespace PersonelTakip.Modeller;

public partial class Personeller
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public byte? Kıdem { get; set; }

    public int? BirimId { get; set; }
}
