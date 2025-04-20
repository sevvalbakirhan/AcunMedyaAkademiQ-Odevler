using System.Reflection;

namespace Reflection_ile_Ödeme_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var odemeTipleri = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(IOdemeYontemi).IsAssignableFrom(t) && t.IsClass);
            cmbOdemeYontemi.DisplayMember = "Name";
            cmbOdemeYontemi.DataSource = odemeTipleri.ToList();
            cmbOdemeYontemi.SelectedIndex = -1; // İlk başta hiçbir şey seçili olmasın

        }

        private void btn_ödeme_Click(object sender, EventArgs e)
        {
           
            if (cmbOdemeYontemi.SelectedItem == null || string.IsNullOrWhiteSpace(txt_tutar.Text))
            {
                MessageBox.Show("Lütfen tutar girin ve ödeme yöntemi seçin.");
                return;
            }

            decimal tutar;
            if (!decimal.TryParse(txt_tutar.Text, out tutar))
            {
                MessageBox.Show("Geçerli bir tutar giriniz.");
                return;
            }

            string secilenTipAdi = cmbOdemeYontemi.SelectedItem.ToString();
            Type secilenTip = Type.GetType(secilenTipAdi);

            if (secilenTip != null)
            {
                IOdemeYontemi odemeNesne = (IOdemeYontemi)Activator.CreateInstance(secilenTip);
                string sonuc = odemeNesne.Ode(tutar);
                lbl_sonuc.Text = sonuc;
            }
        }

    }
}

