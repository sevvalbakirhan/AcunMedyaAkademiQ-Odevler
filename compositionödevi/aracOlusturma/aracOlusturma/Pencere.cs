using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aracOlusturma
{
    public class Pencere
    {
        public int pencereSayisi;
        public Pencere(string pencereSayisi) 
        {
           this.pencereSayisi = Convert.ToInt32(pencereSayisi);
        }
    }
}
