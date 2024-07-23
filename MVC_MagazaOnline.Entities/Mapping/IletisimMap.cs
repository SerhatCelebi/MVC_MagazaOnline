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
    public class IletisimMap:EntityTypeConfiguration<Iletisim>
    {
        public IletisimMap()
        {
            this.ToTable("Iletisim");//tablo adı
            this.HasKey(x => x.Id);//primary key
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//identity özelliği

            
            this.Property(x => x.TelNumara).HasColumnName("TelNumara");//sütun adı

            
            this.Property(x => x.SirketIsmi).HasColumnName("SirketIsmi");//sütun adı

            
            this.Property(x => x.Adres).HasColumnName("Adres");//sütun adı

            
            this.Property(x => x.Mesaj).HasColumnName("Mesaj");//sütun adı

            
            this.Property(x => x.GonderenIsim).HasColumnName("GonderenIsim");//sütun adı

            
            this.Property(x => x.GonderenMail).HasColumnName("GonderenMail");//sütun adı

            
            this.Property(x => x.Tarih).HasColumnName("Tarih");//sütun adı
        }
    }
}
