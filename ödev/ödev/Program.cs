// See https://aka.ms/new-console-template for more information
using ödev;

Bmw bmw = new Bmw();
Audi audi = new Audi();
Mercedes mercedes = new Mercedes();
Porche porche = new Porche();
Togg togg = new Togg();
Toyota toyota = new Toyota();

bmw.vitesBelirt("BMW", "İ5", "düz");
audi.vitesBelirt("Audi", "RS7", "otomatik");
mercedes.vitesBelirt("Mercedes", "S65 AMG", "düz");
porche.vitesBelirt("Porche", "Taycan", "otomatik");
togg.vitesBelirt("Togg","T10X","düz");
toyota.vitesBelirt("Toyota", "Corolla", "düz");

/***********************ÖDEV 2 * **********************
-Abstract class nedir? 
Soyut sınıf demektir.Doğrudan nesne oluşturamaz.Ortak özellikler,ortak methodlar için kullanılabilir.
- Abstraction Nedir?
Soyutlama demektir.Gereksiz ayrıntıların gizlenmesinde kullanılır,kod sadeliği ve okunabilirliği sağlar.Abstract class veya interface ile uygulanır. Bir abstract Method tanımlanır ve bir başka classta bu method istege göre uygulanıp(override) çalıştırır.
- Polymorphism Nedir?
Çok biçimlilik demektir.Aynı isimdeki methodların farklı görevlerde çalışmasıdır.Ortaya overloading çıkar.Amaç kod tekrarını azaltmaktır.

*/




