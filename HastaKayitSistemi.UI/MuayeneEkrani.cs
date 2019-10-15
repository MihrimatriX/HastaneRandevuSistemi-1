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
        DoktorRandevulari doktorRandevulari;
        public MuayeneEkrani(DoktorRandevulari dktr)
        {
            doktorRandevulari = dktr;
            InitializeComponent();
        }

        Context db;
        List<string> teshisler = new List<string>();
        //  List<Recete> ilaclar = new List<Recete>();
        private void MuayeneEkrani_Load(object sender, EventArgs e)
        {
            db = new Context(); ;

        }

        private void btnMuayeneTamamlandi_Click(object sender, EventArgs e)
        {

            MessageBox.Show("işlem tamamlanmıştır");
            doktorRandevulari.Show();
            Close();

        }

        private void chkMuayeneyeGelmedi_CheckedChanged(object sender, EventArgs e)
        {
            doktorRandevulari.Show();
            this.Close();
        }

        

        private void btnIlacEkle_Click(object sender, EventArgs e)
        {
            string verilenIlaclar = txtIlac.Text;

            int girilenNumara = Convert.ToInt32(txtReceteNumarasi.Text);

            var oncedenVarmi = (from k in db.Receteler where k.ReceteID == girilenNumara select k.Ilaclar).FirstOrDefault();

            if (girilenNumara == 0)
                MessageBox.Show("Lütfen bir reçete numarası giriniz!");
            else if (oncedenVarmi != null)
            {
                MessageBox.Show("Recete Numarası başka bir hastaya aittir.Lütfen farklı bir reçete numarası giriniz...");
            }
            else

            {
                Recete recete = new Recete();
                recete.Ilaclar += verilenIlaclar;
                recete.HastaID = girilenNumara;
                recete.DoktorID = girilenNumara;
                dgvIlaclar.Rows.Add(recete.Ilaclar);
                db.Receteler.Add(recete);


            }


        }


    }
}
