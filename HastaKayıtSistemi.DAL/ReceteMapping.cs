using HastaKayitSistemi.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DAL
{
    public class ReceteMapping: EntityTypeConfiguration<Recete>
    {

        public ReceteMapping()
        {
            HasKey(x => x.ReceteID);
            HasRequired(x => x.Hasta).WithMany(x=>x.Receteler).HasForeignKey(x=>x.ReceteID);
        }
    }
}
