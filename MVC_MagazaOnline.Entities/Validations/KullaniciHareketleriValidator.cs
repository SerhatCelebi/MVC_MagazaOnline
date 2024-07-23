using FluentValidation;
using MVC_MagazaOnline.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Validations
{
    public class KullaniciHareketleriValidator : AbstractValidator<KullaniciHareketleri>
    {
        public KullaniciHareketleriValidator()
        {
            RuleFor(x => x.Aciklama).NotEmpty().WithMessage("Kullanıcı Hareketi Açıklaması Boş Geçilemez.");
            RuleFor(x => x.Aciklama).MaximumLength(700).WithMessage("Kullanıcı Hareketi Açıklaması 700 Karakteri Geçemez.");
            RuleFor(x => x.KullaniciId).NotEmpty().WithMessage("Kullanıcı ID Boş Geçilemez.");

        }
    }
}
