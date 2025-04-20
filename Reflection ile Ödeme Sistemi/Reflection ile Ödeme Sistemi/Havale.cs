using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_ile_Ödeme_Sistemi
{
    public class Havale : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            // Havale ile ödeme işlemleri burada yapılır
            // Örnek olarak, sadece bir mesaj döndürüyoruz
            return (tutar + "TL havale ile ödendi.");
        }
    }
   
}
