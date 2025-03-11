// See https://aka.ms/new-console-template for more information
public class araba
{
    public int yasHesapla(int dogumYili)
    {
        int sonuc = DateTime.Now.Year - dogumYili;
        return sonuc;
    }
}
class Program
{
    static void Main(string[] args)
    {
        araba araba1 = new araba();
        Console.WriteLine("Arabanızın Üretim Tarihini Giriniz:");
        int dogumYili = Convert.ToInt32(Console.ReadLine());
        int yas =araba1.yasHesapla(dogumYili);
        Console.WriteLine("Araba Yaşı: " + yas);

        if (yas >= 0 && yas <= 10)
        {
            Console.WriteLine("Arabanız yeni..");
        }
        else if (yas > 10 && yas <= 20)
        {
            Console.WriteLine("Servise götürmeniz gerekebilir..");
        }
        else if (yas > 20 && yas <= 30)
        {
            Console.WriteLine("Arabanız hurdaya çıkabilir..");
        }
        else if (yas < 0 && yas > 30)
        {
            Console.WriteLine("Ya hiç üretilmedi ya da trafikten men edildi..");
        }
        else
        {
            Console.WriteLine("Böyle bir seçeneğiniz yok...");
        }
 //switch case ile nasıl yapılır?
/*int kategori;

 if (yas >= 0 && yas <= 10)
     kategori = 1;
 else if (yas > 10 && yas <= 20)
     kategori = 2;
 else if (yas > 20 && yas <= 30)
     kategori = 3;
 else
     kategori = 4;

 switch (kategori)
 {
     case 1:
         Console.WriteLine("Arabanız yeni.");
         break;
     case 2:
         Console.WriteLine("Servise götürmeniz gerekebilir.");
         break;
     case 3:
         Console.WriteLine("Arabanız hurdaya çıkabilir.");
         break;
     default:
         Console.WriteLine("Böyle bir seçeneğiniz yok.");
         break;
 }
*/
    }
}

