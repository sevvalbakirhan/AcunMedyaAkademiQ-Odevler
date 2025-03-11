using System;

namespace BenzinTuketimi
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] markalar = { "Toyota", "Ford", "BMW", "Renault" };
            string[] modeller = { "Corolla", "Focus", "X5", "Megane" };
            double[] benzinTuketimleri = { 6, 7, 9, 5 }; 

            double toplamTuketim = 0;

            Console.WriteLine("Araba Bilgileri:");
            for (int i = 0; i < markalar.Length; i++)
            {
                Console.WriteLine("Marka: " +markalar[i] + "Model: " + modeller[i] + "Benzin Tüketimi: " +benzinTuketimleri[i] );
                toplamTuketim += benzinTuketimleri[i];
            }

            Console.WriteLine("Toplam Benzin Tüketimi: " + toplamTuketim);
        }
    }
}