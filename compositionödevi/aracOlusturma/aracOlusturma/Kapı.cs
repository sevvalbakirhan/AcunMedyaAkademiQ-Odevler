using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aracOlusturma
{
    public class Kapı
    {
        public int kapıSayisi;

        public Kapı(string kapıSayisi)
        {
            this.kapıSayisi = Convert.ToInt32(kapıSayisi);

        }
    }
}
