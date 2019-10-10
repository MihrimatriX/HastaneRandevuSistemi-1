using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
  public  class Hastane:BaseClass
    {
        public int HastaneID { get; set; }

        public int HastanePoliklinikID { get; set; }
        public string HastaneAdı { get; set; }
        public string Departmanlar { get; set; }
        public virtual List<Poliklinik> HastaneninPoliklinikleri { get; set; }

    }
}
