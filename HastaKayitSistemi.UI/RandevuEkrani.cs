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
    public partial class RandevuEkrani : Form
    {
        public RandevuEkrani()
        {
            InitializeComponent();
        }
        Context db;


        private void RandevuEkrani_Load(object sender, EventArgs e)
        {
            new Context();
            btnDoktorOnayRandevu.Enabled = !btnDoktorOnayRandevu.Enabled;

        }

        private void BtnRandevular_Click(object sender, EventArgs e)
        {
            Randevular randevular = new Randevular();
            this.Close();
            randevular.Show();
        }
    }
}
