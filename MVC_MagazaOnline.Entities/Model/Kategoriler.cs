using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Model
{
    public class Kategoriler
    {
        public int Id { get; set; }
        public string KiyafetKategori { get; set; }
        public string Aciklama { get; set; }
        public List<Kiyafetler> Kiyafetler { get; set; }
    }
}
