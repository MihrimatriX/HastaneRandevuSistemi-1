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
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }
        Context db;

        private void Doktor_Load(object sender, EventArgs e)
        {
            db = new Context();

        }

        private void BtnDoktorGirisi_Click(object sender, EventArgs e)
        {
            if (db.Doktorlar.FirstOrDefault(x => x.KullaniciAdi == txtDoktorAdi.Text && x.Sifre == txtDoktorSifre.Text) != null)
            {
                txtDoktorAdi.Text = txtDoktorSifre.Text = "";
                DoktorRandevuları doktorRandevuları = new DoktorRandevuları();
                this.Hide();
                doktorRandevuları.Show();
            }
            else
            {
                MessageBox.Show("Girdiğiniz Kullanıcı Adı veya Şifre Hatalı! Doğru Bilgileri Girdiğinizden Emin Olunuz.");
            }
        }
    }
}
