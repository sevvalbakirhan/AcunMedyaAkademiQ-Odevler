using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.Models
{
    public class Doktor
    {
        public int ID { get; set; }
        public string DoktorAdi { get; set; }
        public string DoktorSoyadi { get; set; }
        public int BransID { get; set; }
        public string AdSoyad
        {
            get { return $"{DoktorAdi} {DoktorSoyadi} "; }
        }
    }
}
