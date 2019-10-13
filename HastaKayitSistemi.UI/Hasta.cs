using HastaKayitSistemi.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaKayitSistemi.UI
{
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }
        Context db;
        private void Hasta_Load(object sender, EventArgs e)
        {
            db = new Context();
            

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (db.Hastalar.FirstOrDefault(x => x.Email == txtEmail.Text && x.Sifre == txtSifre.Text) != null)
            {
                txtEmail.Text = txtSifre.Text = "";
                RandevuEkrani randevuEkrani = new RandevuEkrani();
                this.Hide();
                randevuEkrani.Show();
            }
            else
            {
                MessageBox.Show("Girdiğiniz Kullanıcı Adı veya Şifre Hatalı! Lütfen Üye Değilseniz Üye Olunuz.");
            }
            
        }

        private void BtnUyeOl_Click(object sender, EventArgs e)
        {
            UyeOlmaEkrani uyeOlmaEkranı = new UyeOlmaEkrani();
            this.Hide();
            uyeOlmaEkranı.Show();

        }
    }
}
