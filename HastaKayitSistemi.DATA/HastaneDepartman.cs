using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
    public class HastaneDepartman
    {
        public int HastaneID { get; set; }
        public int DepartmanID { get; set; }
        public virtual Hastane HastaneninDepartmanlari { get; set; }
        public virtual Departman DepartmanlarinHastaneleri { get; set; }
    }
}
