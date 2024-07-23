using FluentValidation;
using MVC_MagazaOnline.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Validations
{
    public class DuyurularValidation : AbstractValidator<Duyurular>
    {
        public DuyurularValidation()
        {
            RuleFor(x=>x.Baslik).NotEmpty().WithMessage("Başlık Alanı Boş Geçilemez.");
            RuleFor(x=>x.Baslik).Length(5,100).WithMessage("Başlık Alanı 5-100 Karakter Arasında Olmalıdır.");
            RuleFor(x=>x.Duyuru).NotEmpty().WithMessage("Duyuru Alanı Boş Geçilemez.");
            RuleFor(x => x.Baslik).Length(500).WithMessage("Duyuru Alanı 500 Karakteri Geçemez.");
        }
    }
}
