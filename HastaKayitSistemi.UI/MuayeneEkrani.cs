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
    public partial class MuayeneEkrani : Form
    {
        public MuayeneEkrani()
        {
            InitializeComponent();
        }

        Context db;
        List<string> teshisler = new List<string>();
        List<string> ilaclar = new List<string>();
        private void MuayeneEkrani_Load(object sender, EventArgs e)
        {
            db = new Context();;
            //teshisler.Add(txtTeshis.Text);
            //ilaclar.Add(txtIlac.Text);

            
        }

    

        private void txtReceteNumarası_TextChanged(object sender, EventArgs e)
        {
            int girilenNumara = Convert.ToInt32(txtReceteNumarasi.Text);

            var ÖncedenVarMi = (from k in db.Receteler where k.ReceteID == girilenNumara select k.Ilaclar).FirstOrDefault();

            if (ÖncedenVarMi != null)
            {
                MessageBox.Show("Recete Numarası başka bir hastaya aittir.Lütfen farklı bir reçete numarası giriniz...");
            }
            else
            {

            }


            //var ReceteNumarası = (from k in db.Receteler where k.ReceteID == girilenNumara select k.Ilaclar).FirstOrDefault();

        }

       

        private void btnMuayeneTamamlandi_Click(object sender, EventArgs e)
        {


        }

        private void chkMuayeneyeGelmedi_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();

        }

        private void chkTeshisKonulamadı_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTeshisKonulamadı.Checked == true)
            {
               // RandevuEkrani randevuEkrani = new RandevuEkrani();
                //randevuEkrani.btnDoktorOnayliRandevu.Enabled = false;
                //randevuEkrani.btnRandevuAl.Enabled = false;
                this.Hide();
              //  randevuEkrani.Show();
            }
        }
    }
}
