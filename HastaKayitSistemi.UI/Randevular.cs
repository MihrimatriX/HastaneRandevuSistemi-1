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
    public partial class Randevular : Form
    {
        public Randevular()
        {
            InitializeComponent();
        }
        Context db;

        private void CmsSil_Click(object sender, EventArgs e)
        {

            //silmek istediðinizden emin misiniz ?
        }

        private void Randevular_Load(object sender, EventArgs e)
        {
            db = new Context();
            foreach (var item in db.Randevular)
            {
                if (item.HastaID == 1 && item.RandevuIptalMi == 1)
                {
                    dgvRandevuListesi.Rows.Add(item.Hastane.HastaneAdi, item.Departman.DepartmanAdi, item.Doktor.DoktorAdiSoyadi, item.RandevuTarihi);

                }
                //doktor randevutaihi veseansý
            }

        }

        private void Randevular_FormClosed(object sender, FormClosedEventArgs e)
        {
            RandevuEkrani randevuEkrani = new RandevuEkrani();

            randevuEkrani.Show();
        }
    }
}