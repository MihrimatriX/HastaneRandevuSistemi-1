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
    public partial class DoktorRandevuları : Form
    {
        public DoktorRandevuları()
        {
            InitializeComponent();
        }
        Context db;
        private void BtnMuayene_Click(object sender, EventArgs e)
        {
            MuayeneEkrani muayeneEkrani = new MuayeneEkrani();
            this.Hide();
            muayeneEkrani.Show();
        }

        private void DoktorRandevuları_Load(object sender, EventArgs e)
        {
            db = new Context();
            DateTime dtSecilenTarih = dtCalismaGunu.Value;
          
          // String tarih= String.Format("{0:D}", dtSecilenTarih);

            Randevu randevu = new Randevu();
            randevu.RandevuTarihi = dtSecilenTarih;

            foreach (var item in db.Hastalar)
            {
                dgvRandevular.Rows.Add(item.TcNo);

            }
            foreach (var item in db.Randevular)
            {
                dgvRandevular.Rows.Add(item.RandevuTarihi);//seans olarak saat eklenebilir
            }
        }

        private void clndrCalismaGunu_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void dtCalısmaGunu_ValueChanged(object sender, EventArgs e)
        {



        }
    }
}

