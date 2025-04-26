namespace custom_attribute
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtögrSoyad.Enabled = false;
            txtögrBölüm.Enabled = false;
        }

        private void btnBilgileriDogrula_Click(object sender, EventArgs e)
        {
            ögrenciBilgiler ogrenci = new ögrenciBilgiler();
            ogrenci.ögrAd = txtögrAd.Text;
            ogrenci.ögrSoyad = txtögrSoyad.Text;
            ogrenci.ögrBölüm = txtögrBölüm.Text;
            var fields = typeof(ögrenciBilgiler).GetFields();
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
            MessageBox.Show("Ögrenci Adý : " + txtögrAd.Text + " Soyadý : " + txtögrSoyad.Text + " Bölümü :   " + txtögrBölüm.Text);
        }
        private void txtögrAd_TextChanged(object sender, EventArgs e)
        {
            // Eðer txtögrAd boþsa txtögrSoyad ve txtögrBölum devre dýþý býrakýlýr
            bool isögrAdNotEmpty = !string.IsNullOrWhiteSpace(txtögrAd.Text);

            txtögrSoyad.Enabled = isögrAdNotEmpty; // txtögrAd doluysa txtögrSoyad etkin
            txtögrBölüm.Enabled = false; // txtögrAd boþken txtögrBölüm devre dýþý
        }

        private void txtögrSoyad_TextChanged(object sender, EventArgs e)
        {
            bool isögrSoyadNotEmpty = !string.IsNullOrWhiteSpace(txtögrSoyad.Text);

            txtögrBölüm.Enabled = isögrSoyadNotEmpty;
        }

        private void txtögrSoyad_EnabledChanged(object sender, EventArgs e)
        {
            if (txtögrSoyad.Enabled)
            {
                txtögrSoyad.BackColor = Color.White;
            }
            else
            {
                txtögrSoyad.BackColor = Color.DimGray;
            }
        }

        private void txtögrBölüm_EnabledChanged(object sender, EventArgs e)
        {
            if (txtögrBölüm.Enabled)
            {
                txtögrBölüm.BackColor = Color.White;
            }
            else
            {
                txtögrBölüm.BackColor = Color.DimGray;
            }
        }
    }
}
