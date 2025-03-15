// See https://aka.ms/new-console-template for more information

using matematikİslemleri;

namespace matematikİslemleri
{
    class hesaplama
    {
        public int topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
     
        }
}
namespace ProgramTest
{
    class Program
    {
        static void Main(string[] args)
        {
            matematikİslemleri.hesaplama hesap = new matematikİslemleri.hesaplama();
            Console.WriteLine(hesap.topla(7, 6));
            Console.WriteLine(hesap.carp(5, 6));
        }
    }
}
/*Namespace Nedir?

Namespace, C# gibi programlama dillerinde sınıfları, metodları ve diğer bileşenleri düzenlemek için kullanılan bir kapsayıcıdır. Büyük projelerde kodun daha düzenli olmasını sağlar ve isim çakışmalarını önler.

Namespace Kullanmanın Avantajları


*İsim Çakışmalarını Önleme: Aynı isimde iki farklı sınıf oluşturmak istediğinizde, farklı namespace'ler kullanarak çakışmaların önüne geçebilirsiniz.

*Kodun Organizasyonu: Büyük projelerde farklı modülleri veya bileşenleri mantıksal gruplar hâlinde düzenleyerek okunabilirliği artırır.

*Bakımı Kolaylaştırma: İyi organize edilmiş kod, yeni geliştiricilerin projeye adapte olmasını ve hataların daha hızlı tespit edilmesini sağlar.

*Tekrar Kullanılabilirlik: Bir projede oluşturduğunuz kodları, farklı projelerde tekrar kullanmak istiyorsanız namespace kullanımı büyük avantaj sağlar. Örneğin, bir MatematikIslemleri namespace'i içinde yazılmış Hesaplama sınıfını farklı projelere ekleyerek doğrudan kullanabilirsiniz. Bu, kod tekrarını önler ve geliştirme sürecini hızlandırır.

Genişletilebilirlik (Extensibility) Nedir?


Genişletilebilirlik, bir yazılımın gelecekte yeni özellikler eklenerek veya mevcut özellikleri değiştirilerek geliştirilebilme yeteneğidir. İyi tasarlanmış bir yazılım, değişikliklere hızlıca adapte olabilir ve minimum kod değişikliği ile yeni özellikler eklenebilir.

Yazılımın Genişletilebilir Olmasını Sağlama Yöntemleri

*SOLID Prensiplerini Kullanma: Özellikle Açık/Kapalı (Open/Closed) prensibi sayesinde mevcut kod değiştirilmeden genişletilebilir.

*Modüler Mimari Kullanma: Uygulamayı küçük, bağımsız modüller hâlinde tasarlamak, yeni bileşenlerin eklenmesini kolaylaştırır.

*Bağımlılıkları Azaltma: Bağımlılıkları azaltmak için bağımlılık enjeksiyonu (Dependency Injection) gibi tasarım desenleri kullanılabilir.

*Arayüz ve Soyutlama Kullanma: Arayüzler (Interfaces) ve soyut sınıflar (Abstract Classes), yeni bileşenlerin eklenmesini kolaylaştırır.

*Tasarım Desenlerinden Yararlanma: Factory, Strategy, Observer gibi tasarım desenleri, kodun esnekliğini artırarak genişletilebilirliği sağlar.
*/