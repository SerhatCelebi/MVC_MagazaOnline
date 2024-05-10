using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Model.Context
{
    public class KiyafetContext:DbContext
    {
        public KiyafetContext():base("MagazaOnline")
        {
            
        }
        public DbSet<Duyurular> Duyurular { get; set; }
        public DbSet<Hakkimizda> Hakkimizda { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
       
        public DbSet<Kategoriler> Kategoriler { get; set; }
        public DbSet<Kiyafetler> Kiyafetler { get; set; }
        public DbSet<KullaniciHareketleri> KullaniciHareketleri { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<KullaniciRolleri> KullaniciRolleri { get; set; }
        public DbSet<Roller> Roller { get; set; }
        public DbSet<Satislar> Satislar { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Mapping.DuyurularMap());
            modelBuilder.Configurations.Add(new Mapping.IletisimMap());
            modelBuilder.Configurations.Add(new Mapping.HakkimizdaMap());
            modelBuilder.Configurations.Add(new Mapping.KategorilerMap());
            modelBuilder.Configurations.Add(new Mapping.KiyafetlerMap());
            modelBuilder.Configurations.Add(new Mapping.KullaniciHareketleriMap());
            modelBuilder.Configurations.Add(new Mapping.KullanicilarMap());
            modelBuilder.Configurations.Add(new Mapping.KullaniciRolleriMap());
            modelBuilder.Configurations.Add(new Mapping.RollerMap());
            modelBuilder.Configurations.Add(new Mapping.SatislarMap());
            
        }

    }
}
