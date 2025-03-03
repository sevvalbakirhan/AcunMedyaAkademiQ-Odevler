using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    public class Araba
    {
        public string marka;
        public string model;
        public string vites;

        public void vitesBelirt(string marka, string model, string vites)
        {
            Console.WriteLine(marka + " " + model + " " +vites +" viteslidir");
        }
    }
}

