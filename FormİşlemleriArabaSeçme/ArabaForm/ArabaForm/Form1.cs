namespace ArabaForm
{
    public partial class Form1 : Form
    {
        string ad;
        string soyad;
        string marka;
        string model;
        string renk;
        int pencereSayisi;
        int kapiSayisi;
        double yakitTüketimi;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = " Ad: " + ad + "\n" + " Soyad: " + soyad + "\n" + " Marka: " + marka + "\n" +" Model: " + model + "\n" +" Renk: " + renk + "\n" +" Kapý Sayýsý: " + kapiSayisi + "\n" +" Pencere Sayýsý: " + pencereSayisi + "\n" +     " Yakýt Tüketimi: " + yakitTüketimi + " L";

            MessageBox.Show(mesaj, "Araba Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.None); //messagebox ile bilgileri gösterir

        }

        private void cmbPencere_SelectedIndexChanged(object sender, EventArgs e)
        {
            pencereSayisi = Convert.ToInt32(cmbPencere.SelectedItem); //comboboxdan seçilen deðeri pencere sayýsýna atar

        }

        private void cmbRenk_SelectedIndexChanged(object sender, EventArgs e)
        {
            renk = cmbRenk.SelectedItem.ToString(); //comboboxdan seçilen deðeri renk deðiþkenine atar
        }

        private void cmbKapý_SelectedIndexChanged(object sender, EventArgs e)
        {
            kapiSayisi = Convert.ToInt32(cmbKapý.SelectedItem); //comboboxdan seçilen deðeri kapý sayýsýna atar
        }

        private void cmbYakýt_SelectedIndexChanged(object sender, EventArgs e)
        {
            yakitTüketimi = Convert.ToDouble(cmbYakýt.SelectedItem); //comboboxdan seçilen deðeri yakýt tüketimine atar
        }

        private void txtMarka_TextChanged(object sender, EventArgs e)
        {
            marka = txtMarka.Text; //textboxdan alýnan deðeri marka deðiþkenine atar
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            model = txtModel.Text; //textboxdan alýnan deðeri model deðiþkenine atar
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ad = txtAdiniz.Text; //textboxdan alýnan deðeri ad deðiþkenine atar
        }

        private void txtSoyadiniz_TextChanged(object sender, EventArgs e)
        {
            soyad = txtSoyadiniz.Text; //textboxdan alýnan deðeri soyad deðiþkenine atar
        }
    }
}
