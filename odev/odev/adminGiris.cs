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
    public partial class adminGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=eTicaret;Integrated Security=True");
        public adminGiris()
        {
            InitializeComponent();
        }
        Form1 f1;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("select k.kullaniciAdi, k.sifre, a.rol from Kisi k INNER JOIN Admin a ON k.kisiID = a.kisiID WHERE kullaniciAdi=@kullaniciAdi and sifre=@sifre", baglanti);
                komut.Parameters.AddWithValue("@kullaniciAdi", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
                komut.Connection.Open();
                SqlDataReader rd = komut.ExecuteReader(CommandBehavior.CloseConnection);
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        if (rd["rol"].ToString() == "M")
                        {
                            MessageBox.Show("Moderator olarak giris yaptiniz!");
                            moderatorHome moderatorhome = new moderatorHome();
                            this.Hide();
                            moderatorhome.Show();
                        }
                        else
                        {
                            MessageBox.Show("Editor olarak giris yaptiniz!");
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

        private void adminGiris_Load(object sender, EventArgs e)
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
        
    }
}
