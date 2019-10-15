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
    public partial class EczaciReceteBilgileri : Form
    {
        Giris girisFormu;
        public EczaciReceteBilgileri(Giris giris)
        {
            girisFormu = giris;
            InitializeComponent();
        }
        Context db;

        private void btnHastaReceteGecmisi_Click(object sender, EventArgs e)
        {
            HastaReceteGecmisi hastaReceteGecmisi = new HastaReceteGecmisi(this);
            Hide();
            hastaReceteGecmisi.Show();
        }

        private void EczaciReceteBilgileri_Load(object sender, EventArgs e)
        {

            db = new Context();
        }

        private void BtnIlaclariGoruntule_Click(object sender, EventArgs e)
        {
            if (txtReceteNumarasi.Text == "") MessageBox.Show("Lütfen bir reçete numarası giriniz!");
            else
            {
                int girilenNumara = Convert.ToInt32(txtReceteNumarasi.Text);
                var ReceteNumarası = (from k in db.Receteler where k.ReceteID == girilenNumara select k.Ilaclar).FirstOrDefault();
                if (ReceteNumarası == null)
                {
                    MessageBox.Show("Recete numarası yoktur tekrar deneyiniz");
                }
                else
                {
                    lstIlaclar.Items.Add(ReceteNumarası);

                }
                //girilen numara database de yoksa hata alıyor databasede kayıtsızsa seklinde olusturulumalı
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            
            lstIlaclar.Items.Clear();

        }

        private void btnIlacTeslimEdildi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İlaçlarınızı düzenli kullanmayı unutmayınız :)");
        }
        private void EczaciReceteBilgileri_FormClosed(object sender, FormClosedEventArgs e)
        {
            girisFormu.Show();
        }

    }
}
