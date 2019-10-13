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
    public partial class Randevular : Form
    {
        public Randevular()
        {
            InitializeComponent();
        }
        Context db;

        private void CmsSil_Click(object sender, EventArgs e)
        {
           db= new Context();

            //silmek istediğinizden emin misiniz ?
        }

        private void Randevular_Load(object sender, EventArgs e)
        {

        }

        private void Randevular_FormClosed(object sender, FormClosedEventArgs e)
        {
            RandevuEkrani randevuEkrani = new RandevuEkrani();
            
            randevuEkrani.Show();
        }
    }
}
