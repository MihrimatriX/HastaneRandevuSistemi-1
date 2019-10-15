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
    public partial class HastaReceteGecmisi : Form
    {
        EczaciReceteBilgileri eczaciReceteBilgileri;
        public HastaReceteGecmisi(EczaciReceteBilgileri receteBilgileri)
        {
            eczaciReceteBilgileri = receteBilgileri;
            InitializeComponent();
        }
        Context db;

        private void HastaReceteGecmisi_Load(object sender, EventArgs e)
        {
            db = new Context();

        }

        private void BtnIlacKontrol_Click(object sender, EventArgs e)
        {
            eczaciReceteBilgileri.Show();
            Close();
        }

        private void HastaReceteGecmisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            eczaciReceteBilgileri.Show();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            int girilenNumara = Convert.ToInt32(txtHastaNumarasi.Text);
            List<Recete> receteler = db.Receteler.Where(x => x.HastaID == girilenNumara).ToList();
            foreach (Recete item in receteler)
            {
                lblIlaclar.Text += item.Ilaclar.ToString() + "\n";
                //ListViewItem lvi = new ListViewItem();
                // lvi.Text = item.ReceteID.ToString();
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblIlaclar.Text = "";
        }
    }
}
