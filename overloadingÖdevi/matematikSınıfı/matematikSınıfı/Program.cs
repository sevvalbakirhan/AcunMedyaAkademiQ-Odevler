// See https://aka.ms/new-console-template for more information
/*
 * Method Overloading ile Matematik Sınıfı
📌 Görev:
- Matematik işlemleri için bir sınıf oluşturun.
- Toplama,Çarpma işlemleri için method overloading uygulayın.
- İki ve üç parametreli versiyonlarını oluşturun.
- Farklı veri tiplerinde (int, double) kullanımı gösterin.

*/

using matematikSınıfı;

islemler islemler = new islemler();
Console.WriteLine("İki parametreli toplama : " + islemler.toplama(4,5));
Console.WriteLine("Üç parametreli toplama : " + islemler.toplama(4,5,6));
Console.WriteLine("İki parametreli toplama(double) : " + islemler.toplama(4.5, 5.5));
Console.WriteLine("Üç parametreli toplama(double) : " + islemler.toplama(4.5, 5.5, 6.7));
Console.WriteLine("İki parametreli carpma : " + islemler.carpma(4, 5));
Console.WriteLine("Üç parametreli carpma : " + islemler.carpma(4, 5, 6));
Console.WriteLine("İki parametreli carpma(double) : " + islemler.carpma(4.5, 5.5));
Console.WriteLine("Üç parametreli carpma(double) : " + islemler.carpma(4.5, 5.5, 6.5));
/*
C#’ta Garbage Collector Nedir?
📌 Görev:
-Garbage Collector(GC) nedir ve nasıl çalışır?
- Bellek yönetimindeki rolü nedir?

*********NEDİR?**********

Garbage Collector (GC), C#’ta bellekteki artık kullanılmayan nesneleri otomatik olarak temizler ve bellek yönetimini kolaylaştırır. Bu, bellek sızıntılarını önler ve performansı artırır. Geliştiricilerin elle müdahalesine gerek kalmadan, bellek optimizasyonu sağlar.


********NASIL ÇALIŞIR?*******


GC, bellekte yönetilen (managed) nesneler üzerinde çalışır ve şu şekilde işlev görür:

Nesne Kullanımı İzleme: Uygulama çalışırken, GC bellekteki nesneleri izler. Bir nesneye artık ulaşılmıyorsa, bu nesne "çöp" olarak kabul edilir.

Garbage Collection (Toplama): GC, belirli bir zamanda çalışarak bu kullanılmayan nesneleri tespit eder. Ardından, bellekteki bu nesneleri temizler ve belleği yeniden kullanılabilir hale getirir.

Bellek Parçalanmasını Önleme: Bellek temizlendikten sonra, kullanılan bellek bloklarını yeniden düzenleyerek bellekteki parçalanmayı (fragmentation) engeller.


********BELLEK YÖNETİMİNDEKİ ROLÜ NEDİR?*********


GC, arka planda çalışan bir işlem olduğundan, uygulama geliştiricisinin manuel olarak bellek yönetimi yapması gerekmez.
Garbage Collector, bellek yönetiminde şu avantajları sağlar:

Otomatik Bellek Yönetimi: GC, geliştiricilerin bellek tahsisi (allocation) ve serbest bırakma (deallocation) gibi karmaşık işlemlerle uğraşmasını engeller.

Performans Optimizasyonu: Kullanılmayan nesneler düzenli olarak temizlenerek bellek verimliliği artırılır.

Hata Azaltma: Manuel bellek yönetimi sırasında ortaya çıkabilecek bellek sızıntıları (memory leak) veya çifte serbest bırakma (double free) gibi hatalar önlenir.


*/


/*
 Generic Class’lar ve Generic Method’lar (Boxing & Unboxing)
📌 Görev:
-Generic yapıların avantajlarını araştırın.
- Generic sınıf ve metotlarla esnek programlama nasıl yapılır?
- Boxing & Unboxing nedir ve performansa etkisi nedir?


****Generic Yapıların Avantajları****

Tip güvenliği sağlar.
Kod tekrarını önler.
Performansı artırır (Boxing & Unboxing olmaz).

***** Generic Sınıf ve Metotlarla Esnek Programlama******

Generic Sınıf: Aynı kod farklı veri tipleriyle kullanılabilir.
Generic Metot: Farklı türlerle çalışabilen esnek metotlar oluşturur.

*****Boxing & Unboxing ve Performansa Etkisi******

Boxing: Değer tipinin object’e çevrilmesi.
Unboxing: Object’in tekrar değer tipine çevrilmesi.
Etkisi: Ekstra bellek kullanımı ve yavaşlık. Generics kullanarak önlenebilir.


*/