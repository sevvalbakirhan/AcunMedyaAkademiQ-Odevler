using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aracOlusturma
{
    public class Garaj
    {
        public string model;
        public int fiyat;
        public Araba araba;

        public Garaj(string model, int fiyat, Araba araba)
        {
            this.model = model;
            this.fiyat = fiyat;
            this.araba = araba;
        }
    }
}
