using MVC_MagazaOnline.Entities.Mapping;
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
            modelBuilder.Configurations.Add(new DuyurularMap());
            modelBuilder.Configurations.Add(new IletisimMap());
            modelBuilder.Configurations.Add(new HakkimizdaMap());
            modelBuilder.Configurations.Add(new KategorilerMap());
            modelBuilder.Configurations.Add(new KiyafetlerMap());
            modelBuilder.Configurations.Add(new KullaniciHareketleriMap());
            modelBuilder.Configurations.Add(new KullanicilarMap());
            modelBuilder.Configurations.Add(new KullaniciRolleriMap());
            modelBuilder.Configurations.Add(new RollerMap());
            modelBuilder.Configurations.Add(new SatislarMap());
            
        }

    }
}
