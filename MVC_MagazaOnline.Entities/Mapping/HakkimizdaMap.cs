using MVC_MagazaOnline.Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Mapping
{
    public class HakkimizdaMap:EntityTypeConfiguration<Hakkimizda>
    {
        public HakkimizdaMap()
        {
            this.ToTable("Hakkimizda");//tablo adı
            this.HasKey(x => x.Id);//primary key
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//identity özelliği
            
            this.Property(x => x.Adres).HasColumnType("varchar");//sütun tipi
            this.Property(x => x.Adres).IsRequired().HasMaxLength(200);//zorunlu ve max 50 karakter
            this.Property(x => x.Adres).HasColumnName("Adres");

            this.Property(x => x.Sirket).HasColumnType("varchar");
            this.Property(x => x.Sirket).IsRequired().HasMaxLength(50);
            this.Property(x => x.Sirket).HasColumnName("Sirket");

            this.Property(x => x.Aciklama).HasColumnType("varchar");
            this.Property(x => x.Aciklama).IsRequired().HasMaxLength(300);
            this.Property(x => x.Aciklama).HasColumnName("Aciklama");

            this.Property(x => x.KurucuBilgileri).HasColumnType("varchar");
            this.Property(x => x.KurucuBilgileri).IsRequired().HasMaxLength(100);
            this.Property(x => x.KurucuBilgileri).HasColumnName("KurucuBilgileri");


           
        }
    }
}
