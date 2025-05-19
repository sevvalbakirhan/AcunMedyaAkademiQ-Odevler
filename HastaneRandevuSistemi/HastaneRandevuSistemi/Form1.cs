using HastaneRandevuSistemi.Models;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace HastaneRandevuSistemi
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=SEVVALBAKIRHAN\SQLEXPRESS01;Initial Catalog=AcunMedyaÖdevler;Integrated Security=True;TrustServerCertificate=True";
        int BransID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BransGetir();
            DoktorGetir(BransID);
            RandevulariGetir();
            cmb_saat.Items.AddRange(new string[]
            {
                "09:00","10:00","11:00","13:00","14:00","15:00","16:00"
            });
            cmb_saat.SelectedIndex = 0;
        }

        public void BransGetir()
        {
            List<Brans> bransListesi = new List<Brans>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    connection.Open();
                    string sorgu = "SELECT * FROM Branslar";
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    bransListesi = new List<Brans>();
                    bransListesi.Add(new Brans
                    {
                        ID = -1,
                        BransAdi = "Brans seciniz"
                    });

                    while (reader.Read())
                    {
                        bransListesi.Add(new Brans
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            BransAdi = reader["BransAdi"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluþtu: " + ex.Message);
                }
                finally
                {
                    cmb_brans.DataSource = bransListesi;
                    cmb_brans.DisplayMember = "BransAdi";
                    cmb_brans.ValueMember = "ID";
                }
            }
        }
        public void DoktorGetir(int BransID)
        {
            List<Doktor> DoktorListesi = new List<Doktor>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DoktorListesi = new List<Doktor>();
                    connection.Open();
                    string sorgu = "SELECT * FROM Doktorlar where BransID=" + BransID;
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    DoktorListesi = new List<Doktor>();
                    DoktorListesi.Add(new Doktor
                    {
                        ID = 1,
                        DoktorAdi = "Doktor seciniz"
                    });

                    while (reader.Read())
                    {
                        DoktorListesi.Add(new Doktor
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            DoktorAdi = reader["DoktorAdi"].ToString(),
                            DoktorSoyadi = reader["DoktorSoyadi"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluþtu: " + ex.Message);
                }
                finally
                {
                    cmb_doktor.DataSource = DoktorListesi;

                    cmb_doktor.DisplayMember = "AdSoyad";
                    cmb_doktor.ValueMember = "ID";
                }
            }
        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            Brans secilen = (Brans)cmb_brans.SelectedItem;
            int BransID = secilen.ID;
            DoktorGetir(BransID);

        }

        private void btn_randevuOlustur_Click(object sender, EventArgs e)
        {
            if (txt_tc.Text.Length != 11)
            {
                MessageBox.Show("Lütfen geçerli (11 haneli) bir TC Kimlik Numarasý giriniz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_ad.Text) || string.IsNullOrWhiteSpace(txt_soyad.Text) ||
                cmb_brans.SelectedItem == null || cmb_doktor.SelectedItem == null || cmb_saat.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun.");
                return;
            }

            string HastaAdi = txt_ad.Text;
            string HastaSoyadi = txt_soyad.Text;
            string HastaTC = txt_tc.Text;
            int BransID = ((Brans)cmb_brans.SelectedItem).ID;
            int DoktorID = ((Doktor)cmb_doktor.SelectedItem).ID;
         


            DateTime tarih = dtp_tarih.Value.Date;
            string saat = cmb_saat.SelectedItem.ToString();
            DateTime randevuZamani = tarih.Add(TimeSpan.Parse(saat));

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();


                string kontrolSorgusu = "SELECT COUNT(*) FROM Randevular WHERE DoktorID = @doktorID AND Tarih = @tarih";
                SqlCommand kontrolCmd = new SqlCommand(kontrolSorgusu, con);
                kontrolCmd.Parameters.AddWithValue("@doktorID", DoktorID);
                kontrolCmd.Parameters.AddWithValue("@tarih", randevuZamani);

                int sayi = (int)kontrolCmd.ExecuteScalar();

                if (sayi > 0)
                {
                    MessageBox.Show("Bu doktor bu tarih ve saatte zaten dolu.");
                    return;
                }

                string ekleSorgu = @"INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih, HastaTC)
                             VALUES (@adi, @soyadi, @bransID, @doktorID, @tarih, @tc)";
                SqlCommand ekleCmd = new SqlCommand(ekleSorgu, con);
                ekleCmd.Parameters.AddWithValue("@adi", HastaAdi);
                ekleCmd.Parameters.AddWithValue("@soyadi", HastaSoyadi);
                ekleCmd.Parameters.AddWithValue("@bransID", BransID);
                ekleCmd.Parameters.AddWithValue("@doktorID", DoktorID);
                ekleCmd.Parameters.AddWithValue("@tarih", randevuZamani);
                ekleCmd.Parameters.AddWithValue("@tc", HastaTC);

                ekleCmd.ExecuteNonQuery();

                MessageBox.Show("Randevu baþarýyla oluþturuldu.");
            }

            RandevulariGetir();
        }
        private void RandevulariGetir()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sorgu = @"
                SELECT 
                    R.HastaAdi AS [Hasta Adý],
                    R.HastaSoyadi AS [Hasta Soyadý],
                    B.BransAdi AS [Branþ],
                    D.DoktorAdi + ' ' + D.DoktorSoyadi AS [Doktor],
                    R.Tarih AS [Randevu Zamaný],
                    R.HastaTC AS [Hasta TC]
                FROM Randevular R
                INNER JOIN Branslar B ON R.BransID = B.ID
                INNER JOIN Doktorlar D ON R.DoktorID = D.ID
                ORDER BY R.Tarih DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(sorgu, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv_randevular.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }


      
    }

}
 