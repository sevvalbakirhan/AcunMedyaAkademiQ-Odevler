// See https://aka.ms/new-console-template for more information
/*Ödev 4: Diziler ve Döngüler 🚀📊

Ödev: Kullanıcıdan 5 adet sayı alarak bu sayıların ortalamasını hesaplayan bir program yazın.

Yapılması Gerekenler:

Kullanıcıdan 5 tane sayı girişi alın ve bir diziye kaydedin.
for veya foreach döngüsünü kullanarak tüm sayıların toplamını bulun.
Toplamı 5’e bölerek ortalamayı hesaplayın.
Sonucu ekrana yazdırın.
*/

        int[] sayilar = new int[5];
        int toplam = 0;

        Console.WriteLine("Lütfen 5 adet sayı giriniz:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Sayı " + (i+1) + ":");
            sayilar[i] = int.Parse(Console.ReadLine());
            toplam += sayilar[i];
        }
        double ortalama = (double)toplam / 5;

        Console.WriteLine("Girilen sayıların ortalaması: " + ortalama);
    

