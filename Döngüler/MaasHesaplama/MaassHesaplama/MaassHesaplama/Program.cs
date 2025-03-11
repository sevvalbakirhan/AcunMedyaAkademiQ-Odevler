
using System;

namespace MaasHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adlar = { "Ali", "Ayşe", "Mehmet", "Zeynep" };
            string[] soyadlar = { "Yılmaz", "Kaya", "Demir", "Aksoy" };
            string[] meslekler = { "Genel Müdür", "Müdür", "Programcı", "Stajyer" };
            int[] maaslar = { 50000, 30000, 15000, 5000 };
            string[] departmanlar = { "Yönetim", "Satış", "IT", "IT" };

            int toplamMaas = 0;

            Console.WriteLine("Çalışan Bilgileri:");
            for (int i = 0; i < adlar.Length; i++)
            {
                Console.WriteLine("Ad: " + adlar[i] + " Soyad: " + soyadlar[i]  + " Meslek: " + meslekler[i] + " Maaş: " + maaslar[i] + " Departman: " + departmanlar[i]);
                toplamMaas += maaslar[i];
            }
            Console.WriteLine("Toplam Maaş: " + toplamMaas);
        }
    }
}

//WHİLE DÖNGÜSÜ NEDİR?  while döngüsü, belirli bir koşul sağlandığı sürece bir bloğu tekrar tekrar çalıştırmak için kullanılır.
//DO WHİLE DÖNGÜSÜ NEDİR? do while döngüsü, while döngüsüne benzer, ancak farkı, do while döngüsünün koşulun bloğun içinde olduğu ve bloğun en az bir kez çalıştırılacağıdır.
/*
 
       static void Main(string[] args)
       {
           int sayac = 0;
           while (sayac < 5)
           {
               Console.WriteLine("Sayac değeri: " + sayac);
               sayac++;
           }

           Console.WriteLine("Döngü bitti!");
       }



***************************************************************************************************************************************************************

         static void Main(string[] args)
         {
              int sayac = 0;
              do
              {
                Console.WriteLine("Sayac değeri: " + sayac);
                sayac++;
              } while (sayac < 5);
    
              Console.WriteLine("Döngü bitti!");
         }






























*/