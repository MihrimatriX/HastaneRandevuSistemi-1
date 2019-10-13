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

namespace HastaKayitSistemi
{
    public partial class MuayeneEkrani : Form
    {
        public MuayeneEkrani()
        {
            InitializeComponent();
        }
        Context db;

        private void MuayeneEkrani_Load(object sender, EventArgs e)
        {
            db = new Context();


        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                RandevuEkrani randevuEkrani = new RandevuEkrani();
                randevuEkrani.btnDoktorOnayRandevu.Enabled = false;
                randevuEkrani.btnRandevu.Enabled = false;
                this.Hide();
                randevuEkrani.Show();
            }
        }
    }
}
