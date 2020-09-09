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
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=eTicaret;Integrated Security=True");
        public static string kullaniciAdi;
        public static string sifre;
        public static int ID;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            kayit kayit = new kayit();
            this.Hide();
            kayit.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {




            adminGiris adminhome = new adminGiris();
            this.Hide();
            adminhome.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("select kisiID, kullaniciAdi, sifre, silindimi from Kisi WHERE kullaniciAdi=@kullaniciAdi and sifre=@sifre", baglanti);
                komut.Parameters.AddWithValue("@kullaniciAdi", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
                komut.Connection.Open();
                SqlDataReader rd = komut.ExecuteReader(CommandBehavior.CloseConnection);
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        if (rd["silindimi"].ToString() == "False")
                        {
                            kullaniciAdi = txtKullaniciAdi.Text;
                            sifre = txtSifre.Text;
                            ID = Convert.ToInt32(rd["kisiID"]);
                            uyeHome uyehome = new uyeHome();
                            this.Hide();
                            uyehome.Show();
                        }
                        else
                        {
                            MessageBox.Show("Baba hesap yoktir!");
                        }

                    }
                }
                else /// Reader SATIR döndüremiyorsa K.Adı Parola Yanlış Demekdir
                {
                    rd.Close();
                    MessageBox.Show("Kullanıcı Adı veya Parola Geçersizdir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
            catch
            {
                MessageBox.Show("DB ye ulaşılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            
        }

        public static implicit operator Form1(adminGiris v)
        {
            throw new NotImplementedException();
        }
    }
}
