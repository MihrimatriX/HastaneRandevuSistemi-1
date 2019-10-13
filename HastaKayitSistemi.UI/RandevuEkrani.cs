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
    public partial class RandevuEkrani : Form
    {
        public RandevuEkrani()
        {
            InitializeComponent();
        }
        Context db;


        private void RandevuEkrani_Load(object sender, EventArgs e)
        {
            dtRandevuTarihi.MinDate = DateTime.Today.AddDays(1);
            db = new Context();
            btnDoktorOnayRandevu.Enabled = !btnDoktorOnayRandevu.Enabled;
            cmbHastane.DataSource = db.Hastaneler.ToList();
            cmbHastane.DisplayMember = "HastaneAdi";
            cmbHastane.ValueMember = "HastaneID";

            cmbDepartman.DataSource = db.Departmanlar.ToList();
            cmbDepartman.DisplayMember = "DepartmanAdi";
            cmbDepartman.ValueMember = "DepartmanID";

            cmbDoktor.DataSource = db.Doktorlar.ToList();
            cmbDoktor.DisplayMember = "DoktorAdiSoyadi";
            cmbDoktor.ValueMember = "DoktorID";




        }

        private void BtnRandevular_Click(object sender, EventArgs e)
        {
            Randevular randevular = new Randevular();
            this.Close();
            randevular.Show();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {

        }
    }
}
