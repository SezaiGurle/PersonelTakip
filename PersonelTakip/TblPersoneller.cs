using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip
{
    [TabloAdi("Personeller")]
     class Personeller
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public byte Kidem { get; set; }
        public int? BirimId { get; set; }

        public string AdSoyad { get { return Ad + " " + Soyad; } }
    }
}
