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
    public partial class HastaReceteGecmisi : Form
    {
        public HastaReceteGecmisi()
        {
            InitializeComponent();
        }
        Context db;

        private void HastaReceteGecmisi_Load(object sender, EventArgs e)
        {
            db = new Context();
            
            var kullanilanIlaclar = (from k in db.Receteler where k.Ilaclar != null select k.Ilaclar).FirstOrDefault();
            lviKullandigiIlaclar.Items.Add(kullanilanIlaclar);

        }

        private void BtnIlacKontrol_Click(object sender, EventArgs e)
        {
            EczaciReceteBilgileri eczaciReceteBilgileri = new EczaciReceteBilgileri();
            this.Close();
            eczaciReceteBilgileri.Show();
        }
    }
}
