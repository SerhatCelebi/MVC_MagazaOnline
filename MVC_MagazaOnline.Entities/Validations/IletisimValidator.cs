using FluentValidation;
using MVC_MagazaOnline.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Validations
{
    public class IletisimValidator : AbstractValidator<Iletisim>
    {
        public IletisimValidator()
        {
            RuleFor(x=>x.GonderenMail).NotEmpty().WithMessage("Gönderici Maili Boş Geçilemez.");
            RuleFor(x => x.GonderenMail).Length(5,100).WithMessage("Gönderici Maili 5 100 Karakter Arasında Olmalıdır.");
            RuleFor(x => x.GonderenMail).EmailAddress().WithMessage("Geçerli Mail Adresi Giriniz");
            RuleFor(x=>x.TelNumara).NotEmpty().WithMessage("Gönderici Telefonu Boş Geçilemez.");
            RuleFor(x => x.TelNumara).Length(8,15).WithMessage("Gönderici Telefonu 8 15 Karakter Arasında Olmalıdır");
            RuleFor(x=>x.GonderenIsim).NotEmpty().WithMessage("Gönderici İsmi Boş Geçilemez");
            RuleFor(x => x.GonderenIsim).Length(3,60).WithMessage("Gönderici İsmi 3 60 Karakter Arasında Olmalıdır.");

        }
    }
}
