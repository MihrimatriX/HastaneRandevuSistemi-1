using HastaKayitSistemi.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DAL
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.Connection.ConnectionString = "server = .; database = REFFDb; trusted_connection=yes";
        }
        public DbSet<Hasta> Hastalar { get; set; }
        public DbSet<Doktor> Doktorlar { get; set; }
        public DbSet<Eczaci> Eczacilar { get; set; }
        public DbSet<Hastane> Hastaneler { get; set; }
        public DbSet<HastaDoktor> HastaDoktor { get; set; }
        public DbSet<Poliklinik> Poliklinik { get; set; }
        public DbSet<Randevu> Randevular { get; set; }
        public DbSet<Recete> Receteler { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ReceteMapping());
            modelBuilder.Configurations.Add(new HastaDoktorMapping());
            modelBuilder.Configurations.Add(new PoliklinikMapping());
            modelBuilder.Configurations.Add(new RandevuMapping());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
