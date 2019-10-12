using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
     public class Hastane
    {
        public int HastaneID { get; set; }
        public string HastaneAdi { get; set; }
        public virtual List<Doktor> Doktorlar { get; set; }
        public virtual List<Poliklinik> Poliklinikler { get; set; }

        public virtual List<HastaneDepartman> DepartmanlarinHastaneleri { get; set; }

    }
}

