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
    public partial class Eczaci : Form
    {
        Giris girisFormu;
        public Eczaci(Giris giris)
        {
            girisFormu = giris;
            InitializeComponent();
        }
        Context db = new Context();

        private void Eczaci_Load(object sender, EventArgs e)
        {

        }

        private void BtnEczaciGiris_Click(object sender, EventArgs e)
        {
            if (db.Eczacilar.FirstOrDefault(x => x.KullaniciAdi == txtEczaciAdi.Text && x.Sifre == txtEczaciSifre.Text) != null)
            {
                txtEczaciAdi.Text = txtEczaciSifre.Text = "";
                EczaciReceteBilgileri eczaciReceteBilgileri = new EczaciReceteBilgileri(girisFormu);
                Hide();
                eczaciReceteBilgileri.Show();

            }
            else if (Metotlar.BosAlanVarMi(grpEczaci))
            {
                MessageBox.Show("Boş alanları doldurunuz");
            }
            else
            {
                MessageBox.Show("Girdiğiniz Kullanıcı Adı veya Şifre Hatalı! Doğru Bilgileri Girdiğinizden Emin Olunuz.");
            }


        }

        private void Eczaci_FormClosed(object sender, FormClosedEventArgs e)
        {
            girisFormu.Show();
        }
    }

}
