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
    public class KiyafetlerMap:EntityTypeConfiguration<Kiyafetler>
    {
        public KiyafetlerMap()
        {
            this.ToTable("Kiyafetler");//tablo adı
            this.HasKey(x => x.Id);//primary key
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//identity özelliği

            
            this.Property(x => x.Stok).IsRequired();//zorunlu
            this.Property(x => x.Stok).HasColumnName("Stok");//sütun adı

            this.Property(x => x.BarkodNo).IsRequired();//zorunlu
            this.Property(x => x.BarkodNo).HasColumnName("BarkodNo");//sütun adı

            this.Property(x => x.Fiyat).IsRequired();//zorunlu
            this.Property(x => x.Fiyat).HasColumnName("Fiyat");//sütun adı

            this.Property(x => x.KiyafetAdi).IsRequired();//zorunlu
            this.Property(x => x.KiyafetAdi).HasColumnName("KiyafetAdi");//sütun adı

            this.Property(x => x.Aciklama).IsRequired();//zorunlu
            this.Property(x => x.Aciklama).HasColumnName("Aciklama");//sütun adı

            this.Property(x => x.Marka).IsRequired();//zorunlu
            this.Property(x => x.Marka).HasColumnName("Marka");//sütun adı
            this.HasRequired(x=>x.Kategoriler).WithMany(x=>x.Kiyafetler).HasForeignKey(x=>x.KiyafetKategoriId);
            
            
            

        }
    }
}
