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
using System.Drawing.Imaging;

namespace odev
{
    public partial class moderatorHome : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=eTicaret;Integrated Security=True");
        void gridDoldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Uye", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void maceraGridDoldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("select u.urunID, u.kitapAdi, u.kitapTuru, m.fiyat, m.stok, m.basimEvi, m.kitapOzeti from Urunler u INNER JOIN Macera m ON u.urunID = m.urunID", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgvKitaplar.DataSource = tablo;
            baglanti.Close();
        }
        void romanGridDoldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("select u.urunID, u.kitapAdi, u.kitapTuru, r.fiyat, r.stok, r.basimEvi, r.kitapOzeti from Urunler u INNER JOIN Roman r ON u.urunID = r.urunID", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }
        void tarihGridDoldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("select u.urunID, u.kitapAdi, u.kitapTuru, t.fiyat, t.stok, t.basimEvi, t.kitapOzeti from Urunler u INNER JOIN Tarih t ON u.urunID = t.urunID", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView3.DataSource = tablo;
            baglanti.Close();
        }
        public moderatorHome()
        {
            InitializeComponent();
        }
        Form1 f1;

        private void moderatorHome_Load(object sender, EventArgs e)
        {
            gridDoldur();
            maceraGridDoldur();
            romanGridDoldur();
            tarihGridDoldur();
        }

        private void btnYeniAdmin_Click(object sender, EventArgs e)
        {
            pnlKitapEkleGuncelle.Visible = false;
            pnlAdminSec.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Admin(kisiID,rol) values(@kisiID,@rol)", baglanti);
                komut.Parameters.Add("@kisiID", dataGridView1.SelectedRows[0].Cells[0].Value);
                if (radioModerator.Checked)
                {
                    komut.Parameters.Add("@rol", "M");
                }
                else
                {
                    komut.Parameters.Add("@rol", "E");
                }
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarıyla Admin Seçildi!");
            }
            catch (Exception)
            {

                MessageBox.Show("Seçtiğiniz kişiyi ya da Admin türünü kontrol ediniz!");
            }
            
        }

        private void btnResimArama_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pbKitap.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
        }

        int sonKitabinIDBul()
        {
   
            int kayitSayisi=-1;
            SqlCommand komut = new SqlCommand("select count(*) from Urunler", baglanti);
            kayitSayisi = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            SqlCommand komut2 = new SqlCommand("SELECT top 1 urunID FROM Urunler order by urunID desc ", baglanti);
            komut2.Connection.Open();
            SqlDataReader rd = komut2.ExecuteReader();
            if (rd.Read())
            {
                kayitSayisi = Convert.ToInt32(rd["urunID"]);
            }
            rd.Close();
            return kayitSayisi;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Urunler(kitapAdi, kitapTuru) values(@kitapAdi,@kitapTuru)", baglanti);
            komut.Parameters.Add("@kitapAdi", txtKitapAdi.Text);
            komut.Parameters.Add("@kitapTuru", cbKitapTuru.Text);
            komut.ExecuteNonQuery();
            
            if (cbKitapTuru.Text == "Macera")
            {

                SqlCommand komut2 = new SqlCommand("insert into Macera(urunID,fiyat,stok,basimEvi,kitapOzeti) values(@urunID,@fiyat,@stok,@basimEvi,@kitapOzeti)", baglanti);
                komut2.Parameters.AddWithValue("@urunID",sonKitabinIDBul());
                komut2.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                komut2.Parameters.AddWithValue("@stok", txtStok.Text);
                komut2.Parameters.AddWithValue("@basimEvi", txtBasimEvi.Text);
                komut2.Parameters.AddWithValue("@kitapOzeti", rtbKitapOzeti.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (cbKitapTuru.Text == "Tarih")
            {

                SqlCommand komut2 = new SqlCommand("insert into Tarih(urunID,fiyat,stok,basimEvi,kitapOzeti) values(@urunID,@fiyat,@stok,@basimEvi,@kitapOzeti)", baglanti);
                komut2.Parameters.AddWithValue("@urunID", sonKitabinIDBul());
                komut2.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                komut2.Parameters.AddWithValue("@stok", txtStok.Text);
                komut2.Parameters.AddWithValue("@basimEvi", txtBasimEvi.Text);
                komut2.Parameters.AddWithValue("@kitapOzeti", rtbKitapOzeti.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (cbKitapTuru.Text == "Roman")
            {

                SqlCommand komut2 = new SqlCommand("insert into Roman(urunID,fiyat,stok,basimEvi,kitapOzeti) values(@urunID,@fiyat,@stok,@basimEvi,@kitapOzeti)", baglanti);
                komut2.Parameters.AddWithValue("@urunID", sonKitabinIDBul());
                komut2.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                komut2.Parameters.AddWithValue("@stok", txtStok.Text);
                komut2.Parameters.AddWithValue("@basimEvi", txtBasimEvi.Text);
                komut2.Parameters.AddWithValue("@kitapOzeti", rtbKitapOzeti.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            MessageBox.Show("Başarıyla Kayıt Edildi!");
            txtBasimEvi.Text = "";
            txtFiyat.Text = "";
            txtKitapAdi.Text = "";
            txtResim.Text = "";
            txtStok.Text = "";
            rtbKitapOzeti.Text = "";
            moderatorHome moderatorhome = new moderatorHome();
            this.Hide();
            moderatorhome.Show();
            
        }

        private void btnKitapGuncelleEkle_Click(object sender, EventArgs e)
        {
            
            pnlAdminSec.Visible = false;
            pnlKitapEkleGuncelle.Visible = true;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cbKitapTuru.Text == "Macera")
            {
                SqlCommand komut = new SqlCommand("UPDATE Urunler SET kitapAdi=@kitapAdi,kitapTuru=@kitapTuru where urunID=@urunID", baglanti);
                komut.Parameters.AddWithValue("@urunID", dgvKitaplar.SelectedRows[0].Cells[0].Value);
                komut.Parameters.AddWithValue("@kitapAdi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@kitapTuru", cbKitapTuru.Text);
                komut.Connection.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                SqlCommand komut2 = new SqlCommand("UPDATE Macera SET fiyat=@fiyat,stok=@stok,basimEvi=@basimEvi,kitapOzeti=@kitapOzeti where urunID=@urunID", baglanti);
                komut2.Parameters.AddWithValue("@urunID", dgvKitaplar.SelectedRows[0].Cells[0].Value);
                komut2.Parameters.AddWithValue("@stok", Convert.ToInt32(txtStok.Text));
                komut2.Parameters.AddWithValue("@fiyat", Convert.ToDouble(txtFiyat.Text));
                komut2.Parameters.AddWithValue("@basimEvi", txtBasimEvi.Text);
                komut2.Parameters.AddWithValue("@kitapOzeti", rtbKitapOzeti.Text);
                komut2.Connection.Open();
                komut2.ExecuteNonQuery();

            }
            else if (cbKitapTuru.Text == "Roman")
            {
                SqlCommand komut = new SqlCommand("UPDATE Urunler SET kitapAdi=@kitapAdi,kitapTuru=@kitapTuru where urunID=@urunID", baglanti);
                komut.Parameters.AddWithValue("@urunID", dataGridView2.SelectedRows[0].Cells[0].Value);
                komut.Parameters.AddWithValue("@kitapAdi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@kitapTuru", cbKitapTuru.Text);
                komut.Connection.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                SqlCommand komut2 = new SqlCommand("UPDATE Roman SET fiyat=@fiyat,stok=@stok,basimEvi=@basimEvi,kitapOzeti=@kitapOzeti where urunID=@urunID", baglanti);
                komut2.Parameters.AddWithValue("@urunID", dataGridView2.SelectedRows[0].Cells[0].Value);
                komut2.Parameters.AddWithValue("@stok", Convert.ToInt32(txtStok.Text));
                komut2.Parameters.AddWithValue("@fiyat", Convert.ToDouble(txtFiyat.Text));
                komut2.Parameters.AddWithValue("@basimEvi", txtBasimEvi.Text);
                komut2.Parameters.AddWithValue("@kitapOzeti", rtbKitapOzeti.Text);
                komut2.Connection.Open();
                komut2.ExecuteNonQuery();

            }
            else if (cbKitapTuru.Text == "Tarih")
                {
                SqlCommand komut = new SqlCommand("UPDATE Urunler SET kitapAdi=@kitapAdi,kitapTuru=@kitapTuru where urunID=@urunID", baglanti);
                komut.Parameters.AddWithValue("@urunID", dataGridView3.SelectedRows[0].Cells[0].Value);
                komut.Parameters.AddWithValue("@kitapAdi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@kitapTuru", cbKitapTuru.Text);
                komut.Connection.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                SqlCommand komut2 = new SqlCommand("UPDATE Tarih SET fiyat=@fiyat,stok=@stok,basimEvi=@basimEvi,kitapOzeti=@kitapOzeti where urunID=@urunID", baglanti);
                komut2.Parameters.AddWithValue("@urunID", dataGridView3.SelectedRows[0].Cells[0].Value);
                komut2.Parameters.AddWithValue("@stok", Convert.ToInt32(txtStok.Text));
                komut2.Parameters.AddWithValue("@fiyat", Convert.ToDouble(txtFiyat.Text));
                komut2.Parameters.AddWithValue("@basimEvi", txtBasimEvi.Text);
                komut2.Parameters.AddWithValue("@kitapOzeti", rtbKitapOzeti.Text);
                komut2.Connection.Open();
                komut2.ExecuteNonQuery();

            }

            MessageBox.Show("Guncellendi!");
            moderatorHome moderatorhome = new moderatorHome();
            this.Hide();
            moderatorhome.Show();
        }

        private void dgvKitaplar_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {
           
        }

        private void dgvKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvKitaplar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvKitaplar_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int seciliAlan = dgvKitaplar.SelectedCells[0].RowIndex;
            string kitapAdi = dgvKitaplar.Rows[seciliAlan].Cells[1].Value.ToString();
            string kitapTuru = dgvKitaplar.Rows[seciliAlan].Cells[2].Value.ToString();
            string fiyat = dgvKitaplar.Rows[seciliAlan].Cells[3].Value.ToString();
            string stok = dgvKitaplar.Rows[seciliAlan].Cells[4].Value.ToString();
            string basimEvi = dgvKitaplar.Rows[seciliAlan].Cells[5].Value.ToString();
            string kitapOzeti = dgvKitaplar.Rows[seciliAlan].Cells[6].Value.ToString();
            cbKitapTuru.Text = kitapTuru;
            txtKitapAdi.Text = kitapAdi;
            txtFiyat.Text = fiyat;
            txtBasimEvi.Text = basimEvi;
            txtStok.Text = stok;
            rtbKitapOzeti.Text = kitapOzeti;
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dataGridView2.SelectedCells[0].RowIndex;
            string kitapAdi = dataGridView2.Rows[seciliAlan].Cells[1].Value.ToString();
            string kitapTuru = dataGridView2.Rows[seciliAlan].Cells[2].Value.ToString();
            string fiyat = dataGridView2.Rows[seciliAlan].Cells[3].Value.ToString();
            string stok = dataGridView2.Rows[seciliAlan].Cells[4].Value.ToString();
            string basimEvi = dataGridView2.Rows[seciliAlan].Cells[5].Value.ToString();
            string kitapOzeti = dataGridView2.Rows[seciliAlan].Cells[6].Value.ToString();
            cbKitapTuru.Text = kitapTuru;
            txtKitapAdi.Text = kitapAdi;
            txtFiyat.Text = fiyat;
            txtBasimEvi.Text = basimEvi;
            txtStok.Text = stok;
            rtbKitapOzeti.Text = kitapOzeti;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dataGridView3.SelectedCells[0].RowIndex;
            string kitapAdi = dataGridView3.Rows[seciliAlan].Cells[1].Value.ToString();
            string kitapTuru = dataGridView3.Rows[seciliAlan].Cells[2].Value.ToString();
            string fiyat = dataGridView3.Rows[seciliAlan].Cells[3].Value.ToString();
            string stok = dataGridView3.Rows[seciliAlan].Cells[4].Value.ToString();
            string basimEvi = dataGridView3.Rows[seciliAlan].Cells[5].Value.ToString();
            string kitapOzeti = dataGridView3.Rows[seciliAlan].Cells[6].Value.ToString();
            cbKitapTuru.Text = kitapTuru;
            txtKitapAdi.Text = kitapAdi;
            txtFiyat.Text = fiyat;
            txtBasimEvi.Text = basimEvi;
            txtStok.Text = stok;
            rtbKitapOzeti.Text = kitapOzeti;
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
    }
}