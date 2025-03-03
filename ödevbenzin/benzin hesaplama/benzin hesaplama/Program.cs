using benzin_hesaplama;

BMW bMW = new BMW();
Porsche porsche = new Porsche();
Mercedes mercedes = new Mercedes();

double toplamBenzin = 0.0;

toplamBenzin += bMW.benzinLitresi();
toplamBenzin += mercedes.benzinLitresi();
toplamBenzin += porsche.benzinLitresi();

Console.WriteLine("Toplam kullanılan benzin " +toplamBenzin + " L'dir");
