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
        Giris mainForm;
        public Hasta(Giris giris)
        {
            mainForm = giris;
            InitializeComponent();
        }
        Context db;
        private void Hasta_Load(object sender, EventArgs e)
        {
            db = new Context();
            
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (db.Hastalar.FirstOrDefault(x => x.Email == txtKullaniciAdi.Text && x.Sifre == txtSifre.Text) != null)
            {
                txtKullaniciAdi.Text = txtSifre.Text = "";
                RandevuEkrani randevuEkrani = new RandevuEkrani(mainForm);
                this.Hide();
                randevuEkrani.Show();
            }
            else if (Metotlar.BosAlanVarMi(grpHasta))
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!");
            }
            else
            {
                MessageBox.Show("Girdiğiniz Olduğunuz Bilgiler Sisteme Kayıtlı Değil! \nLütfen Üye Olduğunuzdan Emin Olunuz.");
            }

        }

        private void BtnUyeOl_Click(object sender, EventArgs e)
        {
            UyeOlmaEkrani uyeOlmaEkranı = new UyeOlmaEkrani(this);
            this.Hide();
            uyeOlmaEkranı.Show();

        }

        private void Hasta_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
