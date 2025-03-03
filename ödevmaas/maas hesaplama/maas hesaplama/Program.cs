using maas_hesaplama;
GenelMudur genelmudur = new GenelMudur();
Mudur mudur = new Mudur();
Programcı programcı = new Programcı();
Stajyer stajyer = new Stajyer();


double toplamMaas = 0.0 ;
toplamMaas += genelmudur.maasinizNedir();
toplamMaas += mudur.maasinizNedir();
toplamMaas += programcı.maasinizNedir();
toplamMaas += stajyer.maasinizNedir();

Console.WriteLine("Toplam maaş : " + toplamMaas);

