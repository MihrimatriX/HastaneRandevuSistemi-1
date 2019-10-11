using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
    public class Doktor:BaseClass
    {
        public int DoktorID { get; set; }
        public string DoktorAdiSoyadi { get; set; }
        public string DepartmanID { get; set;  }
        public virtual List<HastaDoktor> DoktorunHastalari { get; set; }

        public virtual Departman Departman { get; set; }
        public virtual Hastane Hastane { get; set; }

    }
}
