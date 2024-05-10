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
    public class RollerMap:EntityTypeConfiguration<Roller>
    {
        public RollerMap()
        {
            this.ToTable("Roller");//tablo adı
            this.HasKey(x => x.Id);//primary key
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//identity özelliği
            
        }
    }
}
