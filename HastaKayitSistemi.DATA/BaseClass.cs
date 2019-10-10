using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DATA
{
    public class BaseClass
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Sifre { get; set; }
    }
}
