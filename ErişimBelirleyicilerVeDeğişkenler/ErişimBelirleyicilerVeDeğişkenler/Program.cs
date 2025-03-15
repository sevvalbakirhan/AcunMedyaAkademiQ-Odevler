// See https://aka.ms/new-console-template for more information
/*
 * Ödev İçeriği:

1. Araştırma Kısmı:

⁠ ⁠C# dilinde kullanılan erişim belirleyiciler (public, private, protected, internal) nelerdir? Her birini gerçek hayattan bir örnekle açıklayın.
Erişim belirleyicilerin nesne yönelimli programlamadaki (OOP) rolü nedir?

Public (Herkese Açık)
Bu belirleyici, üyelerin herkese açık ve erişilebilir olduğunu ifade eder.örnegin bir şehrin meydanı.
Private (Özel)
Bu belirleyici, yalnızca aynı sınıf içindeki kod parçalarına erişim sağlar.öernegin bir hastanenin ameliyat odası.
Protected (Korunmuş)
Korunmuş üyeler, yalnızca aynı sınıf ve o sınıfı miras alan alt sınıflar tarafından erişilebilir.örnegin bir ailenin evi.
Internal (Dahili)
Internal üyeler, aynı projedeki diğer sınıflar tarafından erişilebilir. Proje dışındaki kodlara kapalıdır.örnegin bir bankanın icindeki diger birimler.

OOPdeki yeri:

Erişim belirleyiciler, OOP'de kapsülleme ve soyutlama gibi temel prensipleri destekler. 
Kapsülleme ile veriler gizlenir, sadece gereken bilgiler dışarı açılır. 
Soyutlama ile karmaşıklık azaltılarak, dış dünyaya yalnızca önemli detaylar sunulur. Bu, güvenliği artırır,
kod düzenini korur ve yeniden kullanılabilirliği sağlar. 


2.⁠ ⁠Kodlama Kısmı:

⁠ ⁠Bir “Kullanıcı” (User) sınıfı oluşturun.
 ⁠User sınıfında aşağıdaki özellikleri tanımlayın:
 ⁠private string adSoyad (Ad ve Soyad, dışarıdan erişilemez.)
⁠ ⁠private int yas (Yaş, dışarıdan erişilemez.)
⁠ ⁠public string Email (E-posta adresi, dışarıdan erişilebilir.)
⁠ ⁠public void BilgileriGoster() metodu ekleyerek ad, soyad ve yaşı ekrana yazdırın.
⁠ ⁠Kullanıcı sınıfında adSoyad ve yas değişkenlerine erişmek için getter ve setter metotları oluşturun.
⁠ ⁠Main metodu içinde bir User nesnesi oluşturun ve değerlerini ayarlayarak ekrana yazdırın.
*/
using ErişimBelirleyicilerVeDeğişkenler;
using System;

User user = new User();
user.SetAdSoyad("Şevval Bakırhan");
user.SetYas(21);
user.Email = "sevvalbakirhan@gmail.com";
user.BilgileriGoster();
