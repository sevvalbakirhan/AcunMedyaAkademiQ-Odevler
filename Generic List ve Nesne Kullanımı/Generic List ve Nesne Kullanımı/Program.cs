
/*📌 Ödevin Açıklaması

Bir Araba (Car) sınıfı oluşturun. Bu sınıf içinde aşağıdaki özellikler yer almalıdır:

Marka (string) → Arabanın markasını tutar.
Model (string) → Arabanın modelini tutar.
Benzin Harcaması (FuelConsumption) (double) → 100 km başına harcanan yakıt miktarını tutar.
Toplam Mesafe (TotalDistance) (double) → Arabanın toplamda kaç km yol gittiğini tutar.
Daha sonra, bir List<Car> oluşturup en az 3 farklı araba ekleyin.
Son olarak, her arabanın toplamda ne kadar benzin harcadığını hesaplayarak ekrana yazdırın.

📌 İstenen Çıktı Formatı

Konsolda aşağıdaki gibi bir çıktı alınmalıdır:

Marka: Toyota, Model: Corolla, 100 km'de Yaktığı Yakıt: 6.5 litre, Toplam Yakıt Tüketimi: 325 litre  
Marka: BMW, Model: X5, 100 km'de Yaktığı Yakıt: 9.0 litre, Toplam Yakıt Tüketimi: 450 litre  
Marka: Mercedes, Model: C200, 100 km'de Yaktığı Yakıt: 8.2 litre, Toplam Yakıt Tüketimi: 410 litre 

Toplam yakıt tüketimini hesaplamak için şu formülü kullanabilirsiniz:

Toplam Yakıt Tüketimi = (Toplam Mesafe / 100) * 100 km başına Harcanan Yakıt
*/
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Car
{
    public string Marka;
    public string Model;
    public double FuelConsumption;
    public double TotalDistance;

    public double ToplamYakıtTüketimi()
    {
       return (TotalDistance / 100 * FuelConsumption);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>
        {
            new Car { Marka = "Toyota", Model = "Corolla", FuelConsumption = 6.5, TotalDistance = 5000 },
            new Car { Marka = "BMW", Model = "X5", FuelConsumption = 9.0, TotalDistance = 5000 },
            new Car { Marka = "Mercedes", Model = "C200", FuelConsumption = 8.2, TotalDistance = 5000 }
        };
        for (int i = 0; i < cars.Count; i++) 
        {
            Console.WriteLine("Marka: " + cars[i].Marka + " Model: " + cars[i].Model + " 100km de yaktığı yakıt: " + cars[i].FuelConsumption + " litre " + " Toplam Yakıt Tüketimi " + cars[i].ToplamYakıtTüketimi() + " litre");
        }
     
    }
}
