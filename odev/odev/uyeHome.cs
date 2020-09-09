using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace odev
{
    public partial class uyeHome : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=eTicaret;Integrated Security=True");
        public uyeHome()
        {
            InitializeComponent();
        }
        Form1 f1;
        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            SqlCommand komut = new SqlCommand("UPDATE Kisi SET silindimi=@silindimi where kisiID=@kisiID", baglanti);
            komut.Parameters.AddWithValue("@kisiID", Form1.ID);
            komut.Parameters.AddWithValue("@silindimi", "True");
            komut.Connection.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hesap Basariyla Silinmistir!");
        }
        void siparisGetir()
        {
            SqlCommand komut = new SqlCommand("select u.ad, k.kargoAdi, s.fiyat, ur.kitapAdi from Siparisler s INNER JOIN Uye u ON s.kisiID = u.kisiID INNER JOIN KargoFirmasi k ON s.kargoNo = k.kargoNo INNER JOIN Urunler ur ON s.urunID = ur.urunID WHERE u.kisiID=@kisiID", baglanti);
            komut.Parameters.AddWithValue("@kisiID",Form1.ID);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgvSiparisler.DataSource = tablo;
            baglanti.Close();
        }
        private void uyeHome_Load(object sender, EventArgs e)
        {
            siparisGetir();
            try
            {
                string kullaniciAdi = Form1.kullaniciAdi;
                string sifre = Form1.sifre;
                SqlCommand komut = new SqlCommand("select k.kullaniciAdi, k.sifre, u.ad, u.soyad, u.cinsiyet, u.dogumTarihi, i.adres, i.tel, i.email, ilc.ilceAdi, il.ilAdi from Kisi k INNER JOIN Uye u ON k.kisiID = u.kisiID INNER JOIN Iletisim i ON k.kisiID = i.kisiID INNER JOIN Ilce ilc ON i.ilceNo = ilc.IlceNo INNER JOIN Il il ON ilc.ilNo = il.ilNo WHERE kullaniciAdi=@kullaniciAdi and sifre=@sifre", baglanti);
                komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", sifre);
                komut.Connection.Open();
                SqlDataReader rd = komut.ExecuteReader();
                if (rd.Read())
                {
                    txtAd.Text = rd["ad"].ToString();
                    txtSoyad.Text = rd["soyad"].ToString();
                    rctAdres.Text = rd["adres"].ToString();
                    txtTel.Text = rd["tel"].ToString();
                    txtEmail.Text = rd["email"].ToString();
                    lblIlce2.Text = rd["ilceAdi"].ToString();
                    lblIl2.Text = rd["ilAdi"].ToString();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Bir yerde patladik hocam");
            }
            
       }

        private void btnIletisimBilgileri_Click(object sender, EventArgs e)
        {
            pnlSiparisler.Visible = false;
            pnlIletisimBilgileri.Visible = true;  
        }

        private void btnKitaplar_Click(object sender, EventArgs e)
        {
            kitaplar kitap = new kitaplar();
            this.Hide();
            kitap.Show();
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            pnlSiparisler.Visible = true;
            pnlIletisimBilgileri.Visible = false;
        }

        private void dgvSiparisler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1 = new Form1();
            f1.FormClosing += f1_FormClosing;
            f1.ShowDialog();

        }
        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void pnlIletisimBilgileri_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Update Uye set ad=@ad,soyad=@soyad where kisiID=@kisiID", baglanti);
            komut3.Parameters.AddWithValue("@kisiID", Form1.ID);
            komut3.Parameters.AddWithValue("@ad", txtAd.Text);
            komut3.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut3.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("Update Iletisim set adres=@adres,tel=@tel,email=@email where kisiID=@kisiID", baglanti);
            komut2.Parameters.AddWithValue("@kisiID", Form1.ID);
            komut2.Parameters.AddWithValue("@adres", rctAdres.Text);
            komut2.Parameters.AddWithValue("@tel", txtTel.Text);
            komut2.Parameters.AddWithValue("@email", txtEmail.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Güncellendi!");
        }
    }
}
