using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
    public class HastaDoktor 
    {
        public int ID { get; set; }
        public int HastaID { get; set; }
        public int DoktorID { get; set; }

        public virtual Hasta DoktorunHastalari { get; set; }
        public virtual Doktor HastaninDoktorlari { get; set; }

        public string Tahlil { get; set; }

    }
}
