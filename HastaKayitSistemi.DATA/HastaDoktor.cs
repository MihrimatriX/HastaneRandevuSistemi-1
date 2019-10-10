using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
public   class HastaDoktor
    {
        public int HastaID { get; set; }
        public int DoktorID { get; set; }

        public virtual Hasta  HastaninDoktorlari { get; set; }
        public virtual Doktor DoktorunHastalari { get; set; }

        public string Seanslar { get; set; } 

        public DateTime RandevuTarihi { get; set; }

    }   
}
