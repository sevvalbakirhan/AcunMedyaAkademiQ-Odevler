using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benzin_hesaplama
{
    public class BMW : Araba, Ibenzin_hesaplama
    {
        public double benzinLitresi()
        {
            return 80.0;
        }
    }
}
