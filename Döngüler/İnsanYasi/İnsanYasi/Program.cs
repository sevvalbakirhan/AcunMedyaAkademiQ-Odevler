// See https://aka.ms/new-console-template for more information
public class insan
{ 
 public int yasHesapla(int dogumYili)
    {
      int  sonuc = DateTime.Now.Year - dogumYili;
        return sonuc;
    }
}
class Program
{
    static void Main(string[] args)
    {
        insan insan1 = new insan();
        Console.WriteLine("Doğum Yılınızı Giriniz:");
        int dogumYili = Convert.ToInt32(Console.ReadLine());
        int yas = insan1.yasHesapla(dogumYili);
        Console.WriteLine("Yaşınız: " + yas);
      
        if (yas <= 0 && yas <=18)
        {
            Console.WriteLine("Küçüksünüz");
        }
        else if (yas > 18 && yas <= 35)
        {
            Console.WriteLine("Gençsiniz");
        }
        else if (yas > 35 && yas <= 55)
        {
            Console.WriteLine("Yetişkinsiniz");
        }
        else if (yas > 55 && yas <= 75)
        {
            Console.WriteLine("Yaşlısınız");
        }
        else if (yas > 75 && yas <= 99)
        {
            Console.WriteLine("Çok yaşlısınız");
        }
        else
        {
            Console.WriteLine("Ya hiç doğmadınız ya da çoktan öldünüz...");
        }
      }
}
