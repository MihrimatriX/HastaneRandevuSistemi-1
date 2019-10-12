using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
    public class Randevu
    {
        public int RandevuID { get; set; }
        public int HastaneID { get; set; }
        public int PoliklinikID { get; set; }
        public int DepartmanID { get; set; }
        public int DoktorID { get; set; }
        public int HastaID { get; set; }
        public int RandevuIptalMi { get; set; }

        public DateTime RandevuTarihi { get; set; }
        public virtual Doktor Doktor { get; set; }
        public virtual Hasta Hasta{ get; set; }


        //RandevuSaati??



    }
}
