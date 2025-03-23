// See https://aka.ms/new-console-template for more information
/*Ödev: Bilgisayarın rastgele tuttuğu bir sayıyı tahmin etmeye çalışan bir oyun yazın.

Yapılması Gerekenler:

Bilgisayarın 1 ile 100 arasında rastgele bir sayı üretmesini sağlayın.
Kullanıcıdan sayı tahmini alarak, büyük/küçük olduğunu belirtin.
Kullanıcı doğru tahminde bulunana kadar oyunu devam ettirin.
Tahmin sayısını ekrana yazdırın.*/

using System;
Console.WriteLine("Bir sayı tutunuz(1-100)");
int sayi = new Random().Next(1, 101); //C#'ta rastgele bir sayı üretmek için sıkça kullanılan bir yöntemdir. Bu kod,  sınıfını kullanarak 1 ile 100 (dahil) arasında rastgele bir tamsayı oluşturur. new random() Yeni bir rastgele sayı oluşturucu (Random nesnesi) yaratır.
int tahmin = 0;
int tahminSayisi = 0;
while (tahmin != sayi)
{
    tahmin = Convert.ToInt32(Console.ReadLine());
    tahminSayisi++;
    if (tahmin < sayi)
    {
        Console.WriteLine("Daha büyük bir sayı giriniz");
    }
    else if (tahmin > sayi)
    {
        Console.WriteLine("Daha küçük bir sayı giriniz");
    }
    else
    {
        Console.WriteLine("Tebrikler " + tahminSayisi + "tahminde doğru sayıyı buldunuz");
    }
}
