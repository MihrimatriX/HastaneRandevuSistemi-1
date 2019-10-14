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
        DoktorRandevuları doktorRandevuları;
        public MuayeneEkrani(DoktorRandevuları dktr)
        {
            doktorRandevuları = dktr;
            InitializeComponent();
        }

        Context db;
        List<string> teshisler = new List<string>();
        List<Recete> ilaclar = new List<Recete>();
        private void MuayeneEkrani_Load(object sender, EventArgs e)
        {
            db = new Context();;
            //teshisler.Add(txtTeshis.Text);

        }

        private void txtReceteNumarası_TextChanged(object sender, EventArgs e)
        {           
           

        }

       

        private void btnMuayeneTamamlandi_Click(object sender, EventArgs e)
        {


        }

        private void chkMuayeneyeGelmedi_CheckedChanged(object sender, EventArgs e)
        {
            doktorRandevuları.Show();
            this.Close();
        }

        private void chkTeshisKonulamadı_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTeshisKonulamadı.Checked == true)
            {
                RandevuEkrani randevuEkrani = new RandevuEkrani();
                randevuEkrani.btnDoktorOnayliRandevu.Enabled = false;
                randevuEkrani.btnRandevuAl.Enabled = false;
                randevuEkrani.Show();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var verilenIlaclar = txtIlac.Text;

            int girilenNumara = Convert.ToInt32(txtReceteNumarasi.Text);

            var öncedenVarMi = (from k in db.Receteler where k.ReceteID == girilenNumara select k.Ilaclar).FirstOrDefault();

            if (öncedenVarMi != null)
            {
                MessageBox.Show("Recete Numarası başka bir hastaya aittir.Lütfen farklı bir reçete numarası giriniz...");
            }
            else
                
            {
                foreach ( Recete item in db.Receteler)
                {
                    
                    item.Ilaclar = verilenIlaclar;
                    lblSonuc.Text = item.Ilaclar;
                    //burada db ye ılacı ekleyip label da eklenen ilacı görüntülücez .görüntülenmiyorr

                    //    db.Receteler.Add(int.Parse(item.Ilaclar));
                    //       dgvListe.DataSource = db.Receteler.Add(verilenIlaclar);

                }
              //  db.Receteler.Add(lblSonuc.Text);

              //////  lblSonuc.Text = db.Receteler.Add(receteIlac).ToString();
             //////   ilaclar.Add(receteIlac.ToString());
             //////////   lbxIlaclar.Items.Add(ilaclar);

            }

        }
    }
}
