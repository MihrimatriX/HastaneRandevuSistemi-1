using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
    public class HastaneDepartman
    {
        public int ID { get; set; }
        public int HastaneID { get; set; }
        public int DepartmanID { get; set; }
        public virtual Hastane HastaneDepartmanlari { get; set; }
        public virtual Departman DepartmanHastaneleri { get; set; }
    }
}
