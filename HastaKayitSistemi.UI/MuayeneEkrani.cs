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
            db = new Context();

            teshisler.Add(txtTeshis.Text);
            ilaclar.Add(txtIlac.Text);

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTeshisKonulamadi.Checked==true)
            {
                RandevuEkrani randevuEkrani = new RandevuEkrani();
                randevuEkrani.btnDoktorOnayliRandevu.Enabled = false;
                randevuEkrani.btnRandevuAl.Enabled = false;
                this.Hide();
                randevuEkrani.Show();
            }
        }

        private void txtReceteNumarası_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
