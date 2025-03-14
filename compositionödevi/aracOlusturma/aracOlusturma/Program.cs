using aracOlusturma;



Kapı kapı = new Kapı("4");
Pencere pencere = new Pencere("4");
Marka marka = new Marka("BMW");
Kasa kasa = new Kasa("Sedan");
Araba araba = new Araba(kapı, pencere, kasa, marka);
Garaj garaj = new Garaj("X5", 2000000, araba);
Console.WriteLine("Arabanın markası " +  garaj.araba.marka.markaAdi + ", modeli " + garaj.model + ", kapı sayısı " + garaj.araba.kapı.kapıSayisi + ", pencere sayısı " + garaj.araba.pencere.pencereSayisi + ", kasası " + garaj.araba.kasa.kasaTipi + ", fiyatı " + garaj.fiyat + " TL'dir.");





/*🔹 1 - C#’ta Composition Kullanarak Araç Oluşturma
📌 Görev:
-Kapı, Pencere, Kasa ve Marka gibi bileşenleri ayrı sınıflar olarak tanımlayın.
- Araba sınıfı bu bileşenleri içermeli ve Composition kullanılarak oluşturulmalıdır.
- Constructor kullanarak BMW X5 modelini oluşturup ekrana aşağıdaki gibi yazdırın:
🖥 Çıktı Örneği:

"Arabanın markası BMW, modeli X5, kapı sayısı 4, pencere sayısı 4, kasası sedan, fiyatı 2.000.000 TL’dir.
*/