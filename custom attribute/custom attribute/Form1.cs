namespace custom_attribute
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt�grSoyad.Enabled = false;
            txt�grB�l�m.Enabled = false;
        }

        private void btnBilgileriDogrula_Click(object sender, EventArgs e)
        {
            �grenciBilgiler ogrenci = new �grenciBilgiler();
            ogrenci.�grAd = txt�grAd.Text;
            ogrenci.�grSoyad = txt�grSoyad.Text;
            ogrenci.�grB�l�m = txt�grB�l�m.Text;
            var fields = typeof(�grenciBilgiler).GetFields();
            foreach (var field in fields)
            {
                var attributes = field.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);
                if (attributes.Length > 0)
                {
                    var value = field.GetValue(ogrenci);
                    if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                    {
                        var attribute = (ZorunluAlanAttribute)attributes[0];
                        MessageBox.Show(attribute.Mesaj);
                        return;
                    }
                }
            }
            MessageBox.Show("�grenci Ad� : " + txt�grAd.Text + " Soyad� : " + txt�grSoyad.Text + " B�l�m� :   " + txt�grB�l�m.Text);
        }
        private void txt�grAd_TextChanged(object sender, EventArgs e)
        {
            // E�er txt�grAd bo�sa txt�grSoyad ve txt�grB�lum devre d��� b�rak�l�r
            bool is�grAdNotEmpty = !string.IsNullOrWhiteSpace(txt�grAd.Text);

            txt�grSoyad.Enabled = is�grAdNotEmpty; // txt�grAd doluysa txt�grSoyad etkin
            txt�grB�l�m.Enabled = false; // txt�grAd bo�ken txt�grB�l�m devre d���
        }

        private void txt�grSoyad_TextChanged(object sender, EventArgs e)
        {
            bool is�grSoyadNotEmpty = !string.IsNullOrWhiteSpace(txt�grSoyad.Text);

            txt�grB�l�m.Enabled = is�grSoyadNotEmpty;
        }

        private void txt�grSoyad_EnabledChanged(object sender, EventArgs e)
        {
            if (txt�grSoyad.Enabled)
            {
                txt�grSoyad.BackColor = Color.White;
            }
            else
            {
                txt�grSoyad.BackColor = Color.DimGray;
            }
        }

        private void txt�grB�l�m_EnabledChanged(object sender, EventArgs e)
        {
            if (txt�grB�l�m.Enabled)
            {
                txt�grB�l�m.BackColor = Color.White;
            }
            else
            {
                txt�grB�l�m.BackColor = Color.DimGray;
            }
        }
    }
}
