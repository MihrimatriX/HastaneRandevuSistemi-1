using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
    public class Departman
    {
        public int DepartmanID { get; set; }
        public string DepartmanAdi { get; set; }

        public virtual List<Doktor> Doktorlar { get; set; }
        public virtual List<HastaneDepartman> DepartmanlarinHastaneleri { get; set; }

    }
}
