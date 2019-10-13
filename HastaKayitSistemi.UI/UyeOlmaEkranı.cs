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
    public partial class UyeOlmaEkranı : Form
    {

        public UyeOlmaEkranı()
        {
            InitializeComponent();
        }
        Context db;


        private void UyeOlmaEkranı_Load(object sender, EventArgs e)
        {

        }


        private void btnOnayla_Click(object sender, EventArgs e)
        {
            db = new Context();

            if (Metotlar.BosAlanVarMi(grpUye))
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
            else
            {
                DATA.Hasta hastalar = db.Hastalar.FirstOrDefault(x => x.TcNo == txtTcNo.Text || x.Email==txtEmail.Text);

                if (hastalar == null)
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
                    this.Hide();
                    Hasta hasta = new Hasta();
                    hasta.Show();
                }

                MessageBox.Show("Lütfen TcNo veya Emaili tekrar giriniz ...");

            }

        }
    }
}
