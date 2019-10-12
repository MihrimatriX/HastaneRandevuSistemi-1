using HastaKayitSistemi.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DAL
{
    public class HastaneDepartmanMapping : EntityTypeConfiguration<HastaneDepartman>
    {

        public HastaneDepartmanMapping()
        {
            HasRequired(x => x.DepartmanHastaneleri).WithMany(x => x.HastaneDepartmanlari).HasForeignKey(x => x.DepartmanID); ;
            HasRequired(x => x.HastaneDepartmanlari).WithMany(x => x.DepartmanlarinHastaneleri).HasForeignKey(x => x.HastaneID); ;
        }
    }
}
