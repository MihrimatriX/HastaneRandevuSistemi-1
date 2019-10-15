using HastaKayitSistemi.DAL;
using HastaKayitSistemi.DATA;

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
        RandevuEkrani randevuEkrani;

        public Randevular(RandevuEkrani rndv)
        {
            randevuEkrani = rndv;

            InitializeComponent();
        }
        Context db;
        public DATA.Hasta randevular_hasta;

        private void CmsSil_Click(object sender, EventArgs e)
        {

            if (dgvRandevuListesi.Rows[dgvRandevuListesi.CurrentRow.Index].Cells[0].Value != null)
            {
                int id = Convert.ToInt32(dgvRandevuListesi.Rows[dgvRandevuListesi.CurrentRow.Index].Cells[0].Value);
                DialogResult dr = MessageBox.Show("Silme ��lemini onayl�yor musunuz?\n" + id.ToString() + " Numaral� Ranedevunuz Silinecektir!", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //silmek istedi�inizden emin misiniz ?
                    Randevu RandevuSil = db.Randevular.First(x => x.RandevuID == id);
                    RandevuSil.RandevuIptalMi = 0;
                    db.SaveChanges();
                    MessageBox.Show("Randevunuz Ba�ar�yla Silindi!");
                    Randevular_Guncelle();
                }
                else
                {
                    MessageBox.Show("��leminiz �ptal Edildi!");
                }

            }
            else
            {
                MessageBox.Show("Se�im Yapmadan Silme ��lemi Ger�ekle�tirilemez!");
            }


        }

        private void Randevular_Guncelle()
        {
            dgvRandevuListesi.Rows.Clear();
            dgvRandevuListesi.Refresh();
            foreach (var item in db.Randevular)
            {
                if (item.HastaID == randevular_hasta.HastaID && item.RandevuIptalMi == 1)
                {
                    dgvRandevuListesi.Rows.Add(item.RandevuID, item.Hastane.HastaneAdi, item.Departman.DepartmanAdi, item.Doktor.DoktorAdiSoyadi, item.RandevuTarihi);

                }
                //doktor randevutaihi veseans�
            }
        }

        private void Randevular_Load(object sender, EventArgs e)
        {
            db = new Context();
            Randevular_Guncelle();

        }

        private void Randevular_FormClosed(object sender, FormClosedEventArgs e)
        {

            randevuEkrani.Show();
        }
    }
}