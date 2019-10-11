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
        public int DepartmanID { get; set; }
        public DateTime CalismaGunu { get; set; }


    }
}
