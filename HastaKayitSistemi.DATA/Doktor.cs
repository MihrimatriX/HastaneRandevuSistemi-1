using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
    public class Doktor
    {
      
        public int DoktorAdıSoyadı { get; set; }
        public string BranşAdı { get; set; }
        public int BranşID { get; set; }//branşı ile bağlarız
        public DateTime CalısmaGunu { get; set; }
        public virtual List<HastaDoktor> DoktorHastalari { get; set; }

    }
}
