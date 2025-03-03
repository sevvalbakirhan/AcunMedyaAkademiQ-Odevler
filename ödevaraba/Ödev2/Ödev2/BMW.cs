using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
    public class BMW : Araba, IHızLIGit, IUçanAraba, IYüzenAraba
    {
        public void HızlıGit(string isim)
        {
            Console.WriteLine(isim + " çok hızlı gidiyor..");

        }

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
