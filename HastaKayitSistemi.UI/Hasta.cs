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
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }
        Context db;
        private void Hasta_Load(object sender, EventArgs e)
        {
            db = new Context();
            


        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            RandevuEkrani randevuEkrani = new RandevuEkrani();
            this.Hide();
            randevuEkrani.Show();
        }

        private void BtnUyeOl_Click(object sender, EventArgs e)
        {
            UyeOlmaEkranı uyeOlmaEkranı = new UyeOlmaEkranı();
            this.Hide();
            uyeOlmaEkranı.Show();

        }
    }
}
