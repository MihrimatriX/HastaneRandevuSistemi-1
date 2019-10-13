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
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }

        private void Doktor_Load(object sender, EventArgs e)
        {

        }

        private void BtnDoktorGirisi_Click(object sender, EventArgs e)
        {
            DoktorRandevuları doktorRandevuları = new DoktorRandevuları();
            this.Hide();
            doktorRandevuları.Show();
        }
    }
}
