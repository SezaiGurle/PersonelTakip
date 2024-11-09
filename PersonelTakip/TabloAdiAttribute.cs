using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip
{
    internal class TabloAdiAttribute : Attribute
    {
        public string TabloAdi { get; set; }
        public TabloAdiAttribute(string ad) 
        {
            TabloAdi = ad;
        }
    }
}
