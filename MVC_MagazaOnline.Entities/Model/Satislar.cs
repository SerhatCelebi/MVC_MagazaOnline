using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Model
{
    public class Satislar
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public int KiyafetId { get; set; }
        public string Aciklama { get; set; }
        public DateTime SatinAldigiTarih { get; set; }
        public Kiyafetler Kiyafetler { get; set; }
        public Kullanicilar Kullanicilar { get; set; }
        

    }
}
