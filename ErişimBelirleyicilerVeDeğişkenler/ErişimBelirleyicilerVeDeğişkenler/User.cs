using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErişimBelirleyicilerVeDeğişkenler
{
    using System;

   public class User
    {
        
        private string adSoyad; 
        private int yas;
        public string Email;

        public string GetAdSoyad()
        {
            return adSoyad;
        }

        public void SetAdSoyad(string adSoyadDegeri)
        {
            adSoyad = adSoyadDegeri;
        }

        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int yasDegeri)
        {
            yas = yasDegeri;
        }

       
        public void BilgileriGoster()
        {
            Console.WriteLine("Adı Soyadı: " + adSoyad);
            Console.WriteLine("Yaşı: " + yas);
            Console.WriteLine("Email Adresi: "+ Email);
        }
    }


}
