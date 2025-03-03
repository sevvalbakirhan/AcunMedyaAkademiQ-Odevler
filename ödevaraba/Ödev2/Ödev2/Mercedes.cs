using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
    public class Mercedes :Araba, IYüzenAraba, IUçanAraba
    {
        public void UcanAraba(string isim)
        {
            Console.WriteLine(isim + " havada uçuyor..");
        }

        public void YüzenAraba(string isim)
        {
            Console.WriteLine(isim + " denizde yüzüyor..");
        }

      
    }
}
