// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

/*Birinci Yol
Console.WriteLine("Yapmak istediğiniz işlemi seçiniz(+,-,*,/)");
string islem = Console.ReadLine();
Console.WriteLine("İlk sayıyı giriniz");
double  sayi1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("İkinci sayıyı giriniz");
double sayi2 = Convert.ToDouble(Console.ReadLine());
double sonuc = 0.0;

if (islem == "+")
{
    sonuc = sayi1 + sayi2;
    Console.WriteLine(" Toplama Sonucu: " + sonuc);
}
else if (islem == "-")
{
    sonuc = sayi1 - sayi2;
    Console.WriteLine("Çıkarma Sonucu: " + sonuc);
}
else if (islem == "*")
{
    sonuc = sayi1 * sayi2;
    Console.WriteLine("Çarpma Sonucu: " + sonuc);
}
else if (islem == "/")
{
    sonuc = sayi1 / sayi2;
  
    Console.WriteLine("Bölme Sonucu: " + sonuc);
}
else
{
    Console.WriteLine("Geçersiz işlem girdiniz");
}
*/

// İkinci Yol
/*
* İşlem numarası girildiğinde, o işlemi yapacak fonksiyonu çağıran bir program yazınız.
* 
* İşlemler:
* 1 - Toplama
* 2 - Çıkarma
* 3 - Çarpma
* 4 - Bölme
*/



class Program
{
    static void Main(string[] args)
    {
        int islem = 0;
        do
        {
        Console.Write("\nİlk sayıyı giriniz: ");
      
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("İkinci sayıyı giriniz: ");
        
        double b = Convert.ToDouble(Console.ReadLine());
        
    
            Console.WriteLine("\n1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.WriteLine("5 - Çıkış");
            Console.Write("Seçiminizi giriniz: ");
            islem = Convert.ToInt32(Console.ReadLine());

            if (islem == 1)
            {
                Toplama(a, b);
            }
            else if (islem == 2)
            {
                Cikarma(a, b);
            }
            else if (islem == 3)
            {
                Carpma(a, b);
            }
            else if (islem == 4)
            {
                Bolme(a, b);
            }
            else if (islem == 5)
            {
                Console.WriteLine("Çıkış yapılıyor...");
            }
            else
            {
                Console.WriteLine("Geçersiz işlem numarası");
            }
        } while (islem != 5);
    }



    static void Toplama(double a, double b)
    {
        Console.WriteLine("Toplama işlemi yapılıyor...");
        double sonuc = a + b;
        Console.Write("İşlem sonucu: " + sonuc);
    }

    static void Cikarma(double a, double b)
    {
        Console.WriteLine("Çıkarma işlemi yapılıyor...");
        double sonuc = a - b;
        Console.WriteLine("İşlem sonucu: " + sonuc);
    }

    static void Carpma(double a, double b)
    {
        Console.WriteLine("Çarpma işlemi yapılıyor...");
        double sonuc = a * b;
        Console.WriteLine("İşlem sonucu: " + sonuc);
    }

    static void Bolme(double a, double b)
        {
            Console.WriteLine("Bölme işlemi yapılıyor...");
            if (b == 0)
            {
                Console.WriteLine("Bir sayı sıfıra bölünemez.");
                return;
            }
            else
            {
                double sonuc = a / b;
                Console.Write("İşlem sonucu: " + sonuc);
            }
        }
}

