﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Model
{
    public class Roller
    {
        public int Id { get; set; }
        public string Rol { get; set; }
        public List<KullaniciRolleri> KullaniciRolleri { get; set; }
    }
}
