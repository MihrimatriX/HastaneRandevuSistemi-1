using HastaKayitSistemi.DAL;
using HastaKayitSistemi.DATA;
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
    public partial class UyeOlmaEkrani : Form
    {
        Hasta hastaFormu;
        public UyeOlmaEkrani(Hasta hasta)
        {
            hastaFormu = hasta;
            InitializeComponent();
        }
        Context db;
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            db = new Context();

            if (Metotlar.BosAlanVarMi(grpUyeOlmaEkrani))
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
            else
            {
                DATA.Hasta hastalar = db.Hastalar.FirstOrDefault(x => x.TcNo == txtTcNo.Text || x.Email == txtEmail.Text);

                if (hastalar == null)
                {
                    if (txtSifre.Text.Length >= 8 && txtSifre.Text.Length <= 16)
                    {
                        hastalar = new DATA.Hasta
                        {

                            Ad = txtAd.Text,
                            Soyad = txtSoyad.Text,
                            TcNo = txtTcNo.Text,
                            Adres = txtAdres.Text,
                            Telefon = mskTxtTelefon.Text,
                            Email = txtEmail.Text,
                            Sifre = txtSifre.Text,
                            DogumTarihi = dtDogumTarihi.Value

                        };
                        db.Hastalar.Add(hastalar);
                        db.SaveChanges();

                        MessageBox.Show("Kaydınız gerçekleşmiştir...");
                       hastaFormu.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Seçmiş Olduğunuz Şifre 8 Karakterden Az, 16 karakterden fazla Olamaz!");
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz TC Kimlik Numarası Veya E-Mail Adresi Başka Bir Kullanıcıya Aittir.\nLütfen Doğru Bilgileri Girdiğinizden Emin Olunuz!");
                }
            }
        }

        private void UyeOlmaEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            hastaFormu.Show();
        }

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
