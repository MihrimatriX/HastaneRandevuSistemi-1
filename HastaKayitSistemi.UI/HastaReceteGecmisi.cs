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

            //var kullanilanIlaclar = (from k in db.Receteler where k.Ilaclar != null select k.Ilaclar).FirstOrDefault();
            //lviKullandigiIlaclar.Items.Add(kullanilanIlaclar);
            
            

        }

        private void BtnIlacKontrol_Click(object sender, EventArgs e)
        {
            EczaciReceteBilgileri eczaciReceteBilgileri = new EczaciReceteBilgileri();
            this.Close();
            eczaciReceteBilgileri.Show();
        }

        private void txtHastaNumarasi_TextChanged(object sender, EventArgs e)
        {
            int girilenNumara = Convert.ToInt32(txtHastaNumarasi.Text);
            var receteNumarasi = (from k in db.Receteler where k.HastaID == girilenNumara select k.Ilaclar).ToList();
            List<DATA.Recete> receteler = db.Receteler.Where(x => x.HastaID == girilenNumara).ToList();
            foreach (DATA.Recete item in receteler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ReceteID.ToString();
            }
        //    label2.Text = ReceteNumarası.ToString() ;
        }
    }
}
