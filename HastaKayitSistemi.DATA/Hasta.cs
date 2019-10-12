using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
    public class Hasta:BaseClass
    {
        public int HastaID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public string Adres { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string  Telefon { get; set; }
        public string  Email { get; set; }
        public virtual List<HastaDoktor> HastaninDoktorlari { get; set; }

        public virtual List<Recete> Receteler { get; set; }
        public virtual List<Randevu> Randevular { get; set; }



    }
}
