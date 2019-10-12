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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UyeOlmaEkranı uyeOlmaEkranı;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            uyeOlmaEkranı = new UyeOlmaEkranı(this);
            Hide();
            uyeOlmaEkranı.Show();
        }
    }
}
