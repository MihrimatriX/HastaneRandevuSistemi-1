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
    public partial class Giris : Form
    {
        public Giris()
        {

            InitializeComponent();
        }
        Context db;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Context();
        }


        private void BtnHasta_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta(this);
            this.Hide();
            hasta.Show();
        }

        private void BtnDoktor_Click(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();

            this.Hide();

            doktor.Show();
        }

        private void BtnEczaci_Click(object sender, EventArgs e)
        {
            Eczaci eczaci = new Eczaci();
            this.Hide();
            eczaci.Show();
        }
    }
}
