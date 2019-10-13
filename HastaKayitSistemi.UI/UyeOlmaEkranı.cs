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
    public partial class UyeOlmaEkranı : Form
    {

        public UyeOlmaEkranı()
        {
            InitializeComponent();
        }
        Context db;


        private void UyeOlmaEkranı_Load(object sender, EventArgs e)
        {
            db = new Context();

        }

        private void UyeOlmaEkranı_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hasta hasta = new Hasta();
            hasta.Show();
        }
    }
}
