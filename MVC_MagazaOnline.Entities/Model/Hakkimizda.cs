using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Model
{
    public class Hakkimizda
    {
        public int Id { get; set; }
        public string Sirket { get; set; }
        public string Adres { get; set; }
        public string Aciklama { get; set; }
        public string KurucuBilgileri { get; set; }
    }
}
