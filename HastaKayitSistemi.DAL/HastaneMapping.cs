using HastaKayitSistemi.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DAL
{
    public class PoliklinikMapping : EntityTypeConfiguration<Poliklinik>
    {
        public PoliklinikMapping()
        {
            HasKey(x => x.PoliklinikID);
            HasRequired(x => x.Hastane).WithMany(x => x.Poliklinikler).HasForeignKey(x => x.PoliklinikID);
        }
    }
}
