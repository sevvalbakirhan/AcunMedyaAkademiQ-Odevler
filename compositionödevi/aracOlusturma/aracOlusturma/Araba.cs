using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aracOlusturma
{
    public class Araba
    {
        public Kapı kapı;
        public Pencere pencere;
        public Kasa kasa;
        public Marka marka;
        public Araba(Kapı kapı, Pencere pencere, Kasa kasa, Marka marka)
        {
            this.kapı = kapı;
            this.pencere = pencere;
            this.kasa = kasa;
            this.marka = marka;
        }



    }
}

