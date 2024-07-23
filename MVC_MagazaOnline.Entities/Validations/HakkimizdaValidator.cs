using FluentValidation;
using MVC_MagazaOnline.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Validations
{
    public class HakkimizdaValidator:AbstractValidator<Hakkimizda>
    {
        public HakkimizdaValidator()
        {
            RuleFor(x=>x.Adres).NotEmpty().WithMessage("Adres Boş Geçilemez.");
            RuleFor(x=>x.Aciklama).NotEmpty().WithMessage("Açıklama Alanı Boş Geçilemez.");
            RuleFor(x=>x.Adres).Length(10,150).WithMessage("Adres Alanı 10 ve 150 Karakter Arasında Olmalıdır.");
            RuleFor(x => x.Aciklama).Length(5, 150).WithMessage("Açıklama Alanı 5 ve 150 Karakter Arasında Olmalıdır.");
        }
    }
}
