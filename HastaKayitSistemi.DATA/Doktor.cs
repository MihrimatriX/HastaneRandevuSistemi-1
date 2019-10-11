using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
    public class Doktor:BaseClass
    {
        public int DoktorAdiSoyadi { get; set; }
        public string BranşAdi { get; set; }
        public int BranşID { get; set; }//branşı ile bağlarız   
        public DateTime CalismaGunu { get; set; }
        public virtual List<HastaDoktor> DoktorHastalari { get; set; }

    }
}
