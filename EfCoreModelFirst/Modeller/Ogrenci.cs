using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreModelFirst.Modeller
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad {  get; set; }
        public string Soyad { get; set; }
        public int Numara { get; set; }
        public int? Cinsiyet { get; set; }
        public int? SinifId { get; set; } //FK
        public Sinif Sinifi {  get; set; }//Navigation 
    }
}
