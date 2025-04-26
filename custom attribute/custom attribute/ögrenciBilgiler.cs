using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_attribute
{
    public class ögrenciBilgiler
    {
       
           
            [ZorunluAlan("Öğrenci Adı boş bırakılamaz!!")]
            public string ögrAd;
            [ZorunluAlan("Öğrenci Soyadı boş bırakılamaz!!")]
            public string ögrSoyad;
            [ZorunluAlan("Öğrenci Bölümü boş bırakılamaz!!")]
            public string ögrBölüm;

        
    }
}
