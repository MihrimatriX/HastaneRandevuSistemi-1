using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
    public class Poliklinik
    {
        public int PoliklinikID { get; set; }
        public string PoliklinikAdı { get; set; }

        public int HastaneID { get; set; }
        public virtual Hastane Hastane { get; set; }

    }
}
