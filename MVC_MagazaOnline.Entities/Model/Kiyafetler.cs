using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Model
{
    public class Kiyafetler
    {
        public int Id { get; set; }
        public string BarkodNo { get; set; }
        public int KiyafetKategoriId { get; set; }
        public string KiyafetAdi { get; set; }
        public string Marka { get; set; }
        public int Stok { get; set; }
        public int Fiyat { get; set; }
        public bool IndirimVarmi { get; set; }
        public int IndirimTutari { get; set; }
        public DateTime EklenmeTarihi { get; set; }=DateTime.Now;
        public DateTime GuncellemeTarihi { get; set; } = DateTime.Now;
        public  bool SilindiMi { get; set; }
        public string Aciklama { get; set; }
        public Kategoriler Kategoriler  { get; set; }
        
        public List<Satislar> Satislar { get; set; }
        
    }
}
