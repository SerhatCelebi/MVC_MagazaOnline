using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Model
{
    public class Iletisim
    {
        public int Id { get; set; }
        public string TelNumara { get; set; }
        public string SirketIsmi { get; set; }
        public string Adres { get; set; }
        public string Mesaj { get; set; }
        public string GonderenIsim { get; set; }
        public string GonderenMail { get; set; }
        public DateTime Tarih {  get; set; }


    }
}
