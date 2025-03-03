using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
    public class Porsche :Araba , IUçanAraba
    {
        public void UcanAraba(string isim)
        {
            Console.WriteLine(isim + " havada uçuyor..");
        }
    }
}
