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
            dtRandevuTarihi.MaxDate = DateTime.Today.AddDays(30);
            dtRandevuTarihi.MaxSelectionCount = 1;
            db = new Context();
            btnDoktorOnayliRandevu.Enabled = !btnDoktorOnayliRandevu.Enabled;
            cmbHastane.DataSource = db.Hastaneler.ToList();
            cmbHastane.DisplayMember = "HastaneAdi";
            cmbHastane.ValueMember = "HastaneID";

            cmbDepartman.DataSource = db.Departmanlar.ToList();
            cmbDepartman.DisplayMember = "DepartmanAdi";
            cmbDepartman.ValueMember = "DepartmanID";

            cmbDoktor.DataSource = db.Doktorlar.ToList();
            cmbDoktor.DisplayMember = "DoktorAdiSoyadi";
            cmbDoktor.ValueMember = "DoktorID";

            cmbHastane.SelectedIndex = -1;


        }

        private void BtnMevcutRandevularim_Click(object sender, EventArgs e)
        {
            Randevular randevular = new Randevular();
            this.Close();
            randevular.Show();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {

        }

        private void dtRandevuTarihi_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (e.Start.DayOfWeek == DayOfWeek.Saturday || e.Start.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Hafta Sonunu Seçemezsiniz!");
                dtRandevuTarihi.SelectionStart = DateTime.Today.AddDays(1);
            }
        }

        private void CmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHastane.SelectedIndex == -1 && cmbPoliklinik.SelectedIndex == -1)
            {
                cmbDoktor.DataSource = db.Doktorlar.Where(x => x.DepartmanID == (int)cmbDepartman.SelectedValue).ToList();
            }
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
                cmbHastane.DataSource = db.Hastaneler.Where(u => u.Doktorlar.Where(x => x.HastaneID == (int)cmbHastane.SelectedValue).FirstOrDefault() == cmbDoktor.SelectedItem);
            
        }
    }
}
