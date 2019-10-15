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
    public partial class DoktorRandevulari : Form
    {
        Doktor doktorFormu;
        public DoktorRandevulari(Doktor doktor)
        {
            doktorFormu = doktor;
            InitializeComponent();
        }
        Context db;
        public DATA.Doktor doktor;
        private void BtnMuayene_Click(object sender, EventArgs e)
        {
            MuayeneEkrani muayeneEkrani = new MuayeneEkrani(this);
            this.Hide();
            muayeneEkrani.Show();

        }
        private void HastalarGuncelle()
        {
            dgvRandevular.Rows.Clear();
            foreach (var item in db.Randevular)
            {
                if (item.DoktorID == doktor.DoktorID && item.RandevuIptalMi == 1)
                {
                    dgvRandevular.Rows.Add(item.RandevuID, item.Hasta.TcNo, item.Hasta.Ad + item.Hasta.Soyad, item.RandevuTarihi);

                }
                //doktor randevutaihi veseansý
            }
        }
        private void DoktorRandevuları_Load(object sender, EventArgs e)
        {
            db = new Context();
            DateTime dtSecilenTarih = dtCalismaGunu.Value;
            dtCalismaGunu.MinDate = DateTime.Today;
            dtCalismaGunu.MaxDate = DateTime.Today.AddDays(30);

            // String tarih= String.Format("{0:D}", dtSecilenTarih);

            Randevu randevu = new Randevu();
            randevu.RandevuTarihi = dtSecilenTarih;
            HastalarGuncelle();
        }


        private void dtCalısmaGunu_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dtCalismaGunu.Value.ToString());
            DateTime tarih = (DateTime)dtCalismaGunu.Value;
            string randevuTarihi = tarih.ToString("yyyy-MM-dd");



            dgvRandevular.Rows.Clear();


            foreach (var item in db.Randevular)
            {

                DateTime randevuTarihi2 = item.RandevuTarihi;
                string randevuTarihiFormatli = randevuTarihi2.ToString("yyyy-MM-dd");
                if (item.DoktorID == doktor.DoktorID && item.RandevuIptalMi == 1 && randevuTarihiFormatli.Contains(randevuTarihi))
                {
                    dgvRandevular.Rows.Add(item.RandevuID, item.Hasta.TcNo, item.Hasta.Ad + item.Hasta.Soyad, item.RandevuTarihi);

                }
                //doktor randevutaihi veseansý
            }


        }

        private void DoktorRandevuları_FormClosed(object sender, FormClosedEventArgs e)
        {
            doktorFormu.Show();
        }
    }
}

