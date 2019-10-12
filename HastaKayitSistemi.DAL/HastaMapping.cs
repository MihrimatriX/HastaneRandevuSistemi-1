using HastaKayitSistemi.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DAL
{
    public class HastaMapping : EntityTypeConfiguration<Hasta>
    {
        public HastaMapping()
        {
            HasKey(x => x.HastaID);
            Property(x => x.DogumTarihi).HasColumnType("datetime2");
        }
    }
}
