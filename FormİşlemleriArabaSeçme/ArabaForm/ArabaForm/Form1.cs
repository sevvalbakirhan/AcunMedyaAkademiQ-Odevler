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
        double yakitT�ketimi;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = " Ad: " + ad + "\n" + " Soyad: " + soyad + "\n" + " Marka: " + marka + "\n" +" Model: " + model + "\n" +" Renk: " + renk + "\n" +" Kap� Say�s�: " + kapiSayisi + "\n" +" Pencere Say�s�: " + pencereSayisi + "\n" +     " Yak�t T�ketimi: " + yakitT�ketimi + " L";

            MessageBox.Show(mesaj, "Araba Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.None); //messagebox ile bilgileri g�sterir

        }

        private void cmbPencere_SelectedIndexChanged(object sender, EventArgs e)
        {
            pencereSayisi = Convert.ToInt32(cmbPencere.SelectedItem); //comboboxdan se�ilen de�eri pencere say�s�na atar

        }

        private void cmbRenk_SelectedIndexChanged(object sender, EventArgs e)
        {
            renk = cmbRenk.SelectedItem.ToString(); //comboboxdan se�ilen de�eri renk de�i�kenine atar
        }

        private void cmbKap�_SelectedIndexChanged(object sender, EventArgs e)
        {
            kapiSayisi = Convert.ToInt32(cmbKap�.SelectedItem); //comboboxdan se�ilen de�eri kap� say�s�na atar
        }

        private void cmbYak�t_SelectedIndexChanged(object sender, EventArgs e)
        {
            yakitT�ketimi = Convert.ToDouble(cmbYak�t.SelectedItem); //comboboxdan se�ilen de�eri yak�t t�ketimine atar
        }

        private void txtMarka_TextChanged(object sender, EventArgs e)
        {
            marka = txtMarka.Text; //textboxdan al�nan de�eri marka de�i�kenine atar
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            model = txtModel.Text; //textboxdan al�nan de�eri model de�i�kenine atar
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ad = txtAdiniz.Text; //textboxdan al�nan de�eri ad de�i�kenine atar
        }

        private void txtSoyadiniz_TextChanged(object sender, EventArgs e)
        {
            soyad = txtSoyadiniz.Text; //textboxdan al�nan de�eri soyad de�i�kenine atar
        }
    }
}
