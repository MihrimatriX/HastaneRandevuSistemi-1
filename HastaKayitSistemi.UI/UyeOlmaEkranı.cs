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
        Form1 mainForm;

        public UyeOlmaEkranı(Form1 form1)
        {
            mainForm = form1;
            InitializeComponent();
        }
        
        private void UyeOlmaEkranı_Load(object sender, EventArgs e)
        {

        }

        private void UyeOlmaEkranı_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {

        }
    }
}
