using HastaKayitSistemi.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DAL
{
   public class HastaDoktorMapping:EntityTypeConfiguration<HastaDoktor>
    {
        public HastaDoktorMapping()
        {

            HasRequired(x => x.HastaninDoktorlari).WithMany(x =>x.DoktorunHastalari).HasForeignKey(x => x.DoktorID);
            HasRequired(x => x.DoktorunHastalari).WithMany(x => x.HastaninDoktorlari).HasForeignKey(x => x.HastaID);
        }
    }
}
