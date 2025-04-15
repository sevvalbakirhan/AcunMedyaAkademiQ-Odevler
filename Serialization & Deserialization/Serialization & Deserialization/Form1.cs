using System.Text.Json;
using System.Xml.Serialization;

namespace Serialization___Deserialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnJson_Click(object sender, EventArgs e)
        {
            try
            {
                string json= File.ReadAllText("urunler.json");
                List<Urun> urunler = JsonSerializer.Deserialize<List<Urun>>(json);

                string sonuc = "";
                foreach (var urun in urunler)
                {
                    sonuc += "Ürün: " + urun.UrunAdi + ", Fiyat: " + urun.Fiyat + " TL\n";

                }

                MessageBox.Show(sonuc, "Ürünler");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

    }
}

