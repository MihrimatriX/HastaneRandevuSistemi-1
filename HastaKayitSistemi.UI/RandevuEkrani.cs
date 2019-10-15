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

        public DATA.Hasta hasta;

        private void RandevuEkrani_Load(object sender, EventArgs e)
        {

            dtRandevuTarihi.MinDate = DateTime.Today.AddDays(1);
            dtRandevuTarihi.MaxDate = DateTime.Today.AddDays(30);
            dtRandevuTarihi.MaxSelectionCount = 1;
            db = new Context();
            lblHastaAdiSoyadi.Text =hasta.Ad + " " + hasta.Soyad;

            cmbHastane.SelectedIndexChanged -= cmbHastane_SelectedIndexChanged;
            cmbDoktor.SelectedIndexChanged -= cmbDoktor_SelectedIndexChanged;
            cmbPoliklinik.SelectedIndexChanged -= cmbPoliklinik_SelectedIndexChanged;
            cmbDepartman.SelectedIndexChanged -= CmbDepartman_SelectedIndexChanged;
            //cmbPoliklinik.SelectedIndexChanged -= CmbPoliklinik_SelectedIndexChanged;

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


            cmbPoliklinik.DataSource = db.Poliklinik.ToList();
            cmbPoliklinik.DisplayMember = "PoliklinikAdı";
            cmbPoliklinik.ValueMember = "PoliklinikID";

            cmbHastane.SelectedIndex = -1;
            cmbDoktor.SelectedIndex = -1;
            cmbPoliklinik.SelectedIndex = -1;

            cmbPoliklinik.Enabled = false;
            cmbDoktor.Enabled = false;

            panelRandevu.BorderStyle = BorderStyle.Fixed3D;
            int sayac = 30;
            int saat = 09;
            sbyte sira_sayac = 0;
            int top_menzil = 5;
            int dakika = 00;
            int sol_menzil = 5;
            for (int i = 0; saat < 18; i++)
            {

                RadioButton radio = new RadioButton();
                radio.Left = sol_menzil;
                radio.Top = top_menzil;
                radio.AutoSize = false;
                radio.Width = 60;
                radio.Height = 20;
                radio.Text = "";
                if (saat < 10)
                {
                    radio.Text = "0" + radio.Text;
                }
                radio.Text = radio.Text + saat + ":" + dakika;

                if (dakika == 0)
                {
                    radio.Text = radio.Text + "0";
                }
                radio.Font = new Font(radio.Font, FontStyle.Bold);
                radio.BackColor = Color.Green;
                panelRandevu.Controls.Add(radio);
                sira_sayac++;
                sol_menzil = sol_menzil + 65;
                dakika = dakika + sayac;
                if (sira_sayac == 4)
                {
                    sira_sayac = 0;
                    top_menzil = top_menzil + 30;
                    sol_menzil = 5;
                }
                if (dakika == 60)
                {
                    dakika = 0;

                    saat++;
                    if (saat == 13)
                    {
                        saat++;
                    }
                }
            }
            EvenetEkler();
        }
        void EvenetEkler()
        {

            cmbDepartman.SelectedIndexChanged += CmbDepartman_SelectedIndexChanged;
            cmbDoktor.SelectedIndexChanged += cmbDoktor_SelectedIndexChanged;
            //cmbPoliklinik.SelectedIndexChanged += CmbPoliklinik_SelectedIndexChanged;
            cmbHastane.SelectedIndexChanged += cmbHastane_SelectedIndexChanged;
            cmbPoliklinik.SelectedIndexChanged += cmbPoliklinik_SelectedIndexChanged;
        }

        private void BtnMevcutRandevularim_Click(object sender, EventArgs e)
        {
            Randevular randevular = new Randevular(this);
            randevular.randevular_hasta = hasta;
            this.Hide();
            randevular.Show();
        }
        public string HangiSaatSecili(Panel pnl)
        {
            string saat = "";
            foreach (Control item in pnl.Controls)
            {
                if (item is RadioButton)
                {
                    if ((item as RadioButton).Checked)
                    {
                        saat = item.Text;
                        return saat;
                    }
                }
            }
            return saat;
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            if (Metotlar.BosAlanVarMi(grpRandevu) && cmbPoliklinik.Enabled == true)
            {
                MessageBox.Show("Boş Alanları Doldurunuz!");
            }
            else if (cmbDepartman.SelectedIndex >= 0 && cmbDoktor.SelectedIndex >= 0 && cmbHastane.SelectedIndex >= 0)
            {
                if (PanelSaatKontrol(panelRandevu))
                {

                    DateTime tarih = (DateTime)dtRandevuTarihi.SelectionStart;
                    string randevuTarihi = tarih.ToString("yyyy-MM-dd") + " " + HangiSaatSecili(panelRandevu).ToString();
                    DATA.Randevu randevu = new DATA.Randevu();
                    randevu.HastaID = hasta.HastaID;
                    randevu.HastaneID = (int)cmbHastane.SelectedValue;
                    randevu.DepartmanID = (int)cmbDepartman.SelectedValue;
                    randevu.DoktorID = (int)cmbDoktor.SelectedValue;
                    randevu.RandevuIptalMi = 1;
                    if (cmbPoliklinik.Enabled)
                        randevu.PoliklinikID = (int)cmbPoliklinik.SelectedValue;
                    else
                        randevu.PoliklinikID = 1;
                    randevu.RandevuTarihi = Convert.ToDateTime(randevuTarihi);
                    db.Randevular.Add(randevu);
                    db.SaveChanges();
                    MessageBox.Show("Randevu Kaydınız Alındı!");
                }
                else
                {
                    MessageBox.Show("Lütfen Saat Seçiniz!");
                }


            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Seçiniz!");
            }
        }

        private bool PanelSaatKontrol(Panel pnl)
        {
            bool bos = false;

            foreach (Control item in pnl.Controls)
            {
                if (item is RadioButton)
                {
                    if ((item as RadioButton).Checked)
                    {
                        return true;
                    }
                }
            }

            return bos;
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
            cmbDoktor.DataSource = db.Doktorlar.Where(x => x.DepartmanID == (int)cmbDepartman.SelectedValue).ToList();

            List<int> hastaneIdler = db.HastaneDepartman.Where(x => x.DepartmanID == (int)cmbDepartman.SelectedValue).Select(x => x.HastaneID).ToList();
            //var results = db.HastaneDepartman.Where(x => .Contains(x.SomeColumn));
            List<DATA.Hastane> hasteneler = new List<DATA.Hastane>();
            foreach (int id in hastaneIdler)
            {
                hasteneler.Add(db.Hastaneler.Find(id));
            }

            List<DATA.Departman> departmanlar = db.Departmanlar.Where(x => x.DepartmanID == (int)cmbDepartman.SelectedValue).ToList();
            cmbHastane.DataSource = hasteneler;
            cmbDoktor.Enabled = true;
        }
        private void cmbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPoliklinik.DataSource = db.Poliklinik.Where(x => x.HastaneID == (int)cmbHastane.SelectedValue).ToList();
            if (cmbPoliklinik.Text == "" || cmbPoliklinik.Text == "Poliklinik Yok")
            {
                cmbPoliklinik.Enabled = false;
            }
            else
            {
                cmbPoliklinik.Enabled = true;
            }
            cmbDoktor.DataSource = db.Doktorlar.Where(x => x.HastaneID == (int)cmbHastane.SelectedValue).ToList();

        }

        private void cmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

            //int HastaneID = (from k in db.Doktorlar where k.DoktorID == (int)cmbDoktor.SelectedValue select k.HastaneID).FirstOrDefault();
            //cmbHastane.SelectedValue = HastaneID;


            // Poliklinik
            int PoliklinikID = db.Doktorlar.Where(o => o.DoktorID == (int)cmbDoktor.SelectedValue).Select(x => x.PoliklinikID).FirstOrDefault();


            if (PoliklinikID == 1)
            {
                cmbPoliklinik.Enabled = false;
            }
            if (PoliklinikID != 1)
            {
                cmbPoliklinik.Enabled = true;
            }
            // Departman
            //int DepartmanID = db.Doktorlar.Where(o => o.DoktorID == (int)cmbDoktor.SelectedValue).Select(x => x.DepartmanID).FirstOrDefault();
            //cmbDepartman.SelectedValue = DepartmanID;
        }

        private void RandevuEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
