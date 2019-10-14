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
        public EczaciReceteBilgileri()
        {
            InitializeComponent();
        }
        Context db;

        private void Button2_Click(object sender, EventArgs e)
        {

            this.Close();
            HastaReceteGecmisi hastaReceteGecmisi = new HastaReceteGecmisi();
            hastaReceteGecmisi.Show();
        }

        private void EczaciReceteBilgileri_Load(object sender, EventArgs e)
        {


        }

        private void BtnIlaclariGoruntule_Click(object sender, EventArgs e)
        {
            db = new Context();
            int girilenNumara = Convert.ToInt32(txtReceteNumarasi.Text);
            var ReceteNumarası = (from k in db.Receteler where k.ReceteID == girilenNumara select k.Ilaclar).FirstOrDefault();
            lsvIlaclar.Items.Add(ReceteNumarası);

        }
    }
}
