using FluentValidation;
using MVC_MagazaOnline.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Validations
{
    public class SatislarValidator:AbstractValidator<Satislar>
    {
        public SatislarValidator()
        {
            RuleFor(x => x.Aciklama).NotEmpty().WithMessage("Satış Açıklama Boş Geçilemez.");
            RuleFor(x => x.Aciklama).MaximumLength(200).WithMessage("Satış Açıklama En Fazla 200 Karakter Olmalıdır.");
        }
    }
}
