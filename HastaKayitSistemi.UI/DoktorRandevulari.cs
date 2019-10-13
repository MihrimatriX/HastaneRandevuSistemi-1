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
    public partial class DoktorRandevuları : Form
    {
        public DoktorRandevuları()
        {
            InitializeComponent();
        }

        private void BtnMuayene_Click(object sender, EventArgs e)
        {
            MuayeneEkrani muayeneEkrani = new MuayeneEkrani();
            this.Hide();
            muayeneEkrani.Show();
        }
    }
}
