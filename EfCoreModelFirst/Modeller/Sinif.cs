using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreModelFirst.Modeller
{
    public class Sinif
    {
        public int Id { get; set; }

        [MaxLength(15)]
        public string Ad {  get; set; }

        public List<Ogrenci> Ogrenciler { get; set; } = new();

    }
}
