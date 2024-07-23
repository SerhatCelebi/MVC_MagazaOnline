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
    public class DuyurularMap:EntityTypeConfiguration<Duyurular>
    {
        public DuyurularMap()
        {
            this.ToTable("Duyurular");//tablo adı
            this.HasKey(x => x.Id);//primary key
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//identity özelliği
            this.Property(x => x.Baslik).HasColumnType("varchar");//sütun tipi
            
            this.Property(x => x.Duyuru).HasColumnType("varchar");
            
            this.Property(x => x.Aciklama).HasColumnType("varchar");
            
            this.Property(x => x.Id).HasColumnName("Id");//sütun adı
            this.Property(x => x.Baslik).HasColumnName("Baslik");
            this.Property(x => x.Duyuru).HasColumnName("Duyuru");
            this.Property(x => x.Aciklama).HasColumnName("Aciklama");
            this.Property(x => x.Tarih).HasColumnName("Tarih");
        }
    }
}
