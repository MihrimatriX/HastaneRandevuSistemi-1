using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
    public class Recete
    {
        public int ReceteID { get; set; }
        public int HastaID { get; set; }
        public int DoktorID { get; set; }
        public string Ilaclar { get; set; }

        public virtual Hasta Hasta { get; set; }

    }
}
