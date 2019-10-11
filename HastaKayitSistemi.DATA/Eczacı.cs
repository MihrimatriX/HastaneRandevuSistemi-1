using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
    public class Eczacı : BaseClass
    {
        public int HastaID { get; set; }
        public int ReceteNumarası { get; set; }
        public int Recete { get; set; }
        public virtual List<Hasta> EczacıyaGelenHastalar { get; set; }

    }
}
