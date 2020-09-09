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
    public partial class kayit : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=eTicaret;Integrated Security=True");

        public kayit()
        {
            InitializeComponent();
        }
        int sonKisininIDBul()
        {

            int kayitSayisi = -1;
            SqlCommand komut = new SqlCommand("select count(*) from Kisi", baglanti);
            kayitSayisi = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            SqlCommand komut2 = new SqlCommand("SELECT top 1 kisiID FROM Kisi order by kisiID desc ", baglanti);
            komut2.Connection.Open();
            SqlDataReader rd = komut2.ExecuteReader();
            if (rd.Read())
            {
                kayitSayisi = Convert.ToInt32(rd["kisiID"]);
            }
            rd.Close();
            return kayitSayisi+1;
        }
        Form1 f1;
        private void btnKayit_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kisi(kullaniciAdi, sifre) values('" + txtKullaniciAdi.Text + "','" + txtSifre.Text + "')",baglanti);
            SqlCommand komut2 = new SqlCommand("insert into Uye(ad, soyad,cinsiyet,dogumTarihi) values(@ad,@soyad,@cinsiyet,@dogumTarihi)", baglanti);
            SqlCommand komut3 = new SqlCommand("insert into Iletisim(kisiID,ilceNo,adres,tel,email) values(@kisiID,@ilceNo,'Bos','0','Bos')", baglanti);
            komut3.Parameters.AddWithValue("@kisiID", sonKisininIDBul());
            komut3.Parameters.AddWithValue("@ilceNo", 13);
            komut2.Parameters.AddWithValue("@ad",txtAd.Text);
            komut2.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            if (radioErkek.Checked)
            {
                komut2.Parameters.AddWithValue("@cinsiyet", "Erkek");
            }
            else
            {
                komut2.Parameters.AddWithValue("@cinsiyet", "Kadin");
            }
            komut2.Parameters.AddWithValue("@dogumTarihi", dateDogumTarihi.Value.Date);
            komut.ExecuteNonQuery();
            komut2.ExecuteNonQuery();
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Kayıt Olundu!");
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

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}//Data Source=.;Initial Catalog=eTicaret;Integrated Security=True
