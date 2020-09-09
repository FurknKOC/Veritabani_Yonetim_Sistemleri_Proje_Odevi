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
    public partial class kitaplar : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=eTicaret;Integrated Security=True");
        string kullaniciAdi = Form1.kullaniciAdi;
        string sifre = Form1.sifre;
        int ID = Form1.ID;
        public kitaplar()
        {
            InitializeComponent();
        }
        uyeHome uh;
        void maceraGridDoldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("select u.urunID, u.kitapAdi, u.kitapTuru, m.fiyat, m.stok, m.basimEvi, m.kitapOzeti from Urunler u INNER JOIN Macera m ON u.urunID = m.urunID", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgvMacera.DataSource = tablo;
            baglanti.Close();
        }
        void romanGridDoldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("select u.urunID, u.kitapAdi, u.kitapTuru, r.fiyat, r.stok, r.basimEvi, r.kitapOzeti from Urunler u INNER JOIN Roman r ON u.urunID = r.urunID", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgvRoman.DataSource = tablo;
            baglanti.Close();
        }
        void tarihGridDoldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("select u.urunID, u.kitapAdi, u.kitapTuru, t.fiyat, t.stok, t.basimEvi, t.kitapOzeti from Urunler u INNER JOIN Tarih t ON u.urunID = t.urunID", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgvTarih.DataSource = tablo;
            baglanti.Close();
        }
        void kargoGetir()
        {
            SqlCommand komut = new SqlCommand("select kargoNo, kargoAdi, kargoFiyati from KargoFirmasi", baglanti);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbKargo.Items.Add(dr["kargoAdi"]);
            }
            
            baglanti.Close();
        }
        private void btnMacera_Click(object sender, EventArgs e)
        {
            pnlMacera.Visible = true;
            panelRoman.Visible = false;
            panelTarih.Visible = false;
        }

        private void kitaplar_Load(object sender, EventArgs e)
        {
            maceraGridDoldur();
            romanGridDoldur();
            tarihGridDoldur();
            kargoGetir();
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Siparisler (kisiID, kargoNo,fiyat,urunID) values(@kisiID,@kargoNo,@fiyat,@urunID)", baglanti);
            komut.Parameters.AddWithValue("@kisiID", Form1.ID);
            if (cbKargo.Text == "Aras")
            {
                komut.Parameters.AddWithValue("@kargoNo", 1);
            }
            else if (cbKargo.Text == "PttKargo")
            {
                komut.Parameters.AddWithValue("@kargoNo", 2);
            }
            else if (cbKargo.Text == "UpsKargo")
            {
                komut.Parameters.AddWithValue("@kargoNo", 5);
            }
            if (pnlMacera.Visible == true)
            {
                komut.Parameters.AddWithValue("@fiyat", dgvMacera.SelectedRows[0].Cells[3].Value);
                komut.Parameters.AddWithValue("@urunID", dgvMacera.SelectedRows[0].Cells[0].Value);
            }
            else if (panelTarih.Visible == true)
            {
                komut.Parameters.AddWithValue("@fiyat", dgvTarih.SelectedRows[0].Cells[3].Value);
                komut.Parameters.AddWithValue("@urunID", dgvTarih.SelectedRows[0].Cells[0].Value);
            }
            else if (panelRoman.Visible == true)
            {
                komut.Parameters.AddWithValue("@fiyat", dgvRoman.SelectedRows[0].Cells[3].Value);
                komut.Parameters.AddWithValue("@urunID", dgvRoman.SelectedRows[0].Cells[0].Value);

            }

            komut.ExecuteNonQuery();
            MessageBox.Show("Basarili bir sekilde satin aldiniz!");

            uyeHome uyehome = new uyeHome();
            this.Hide();
            uyehome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelRoman.Visible = true;
            pnlMacera.Visible = false;
            panelTarih.Visible = false;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            uh = new uyeHome();
            uh.FormClosing += f1_FormClosing;
            uh.ShowDialog();

        }
        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelTarih.Visible = true;
            panelRoman.Visible = false;
            pnlMacera.Visible = false;
        }

        private void dgvRoman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlMacera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvMacera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
