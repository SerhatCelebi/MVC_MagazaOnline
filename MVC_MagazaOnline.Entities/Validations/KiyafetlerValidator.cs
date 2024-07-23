using FluentValidation;
using MVC_MagazaOnline.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Validations
{
    public class KiyafetlerValidator:AbstractValidator<Kiyafetler>
    {
        public KiyafetlerValidator()
        {
            RuleFor(x=>x.KiyafetAdi).NotEmpty().WithMessage("Kıyafet Adı Boş Geçilemez.");
            RuleFor(x=> x.KiyafetAdi).MaximumLength(50).WithMessage("Kıyafet Adı En Fazla 50 Karakter Olabilir.");
            RuleFor(x=>x.Marka).NotEmpty().WithMessage("Marka Adi Boş Geçilemez.");
            RuleFor(x=>x.Stok).GreaterThan(0).WithMessage("Stok Adedi 0 dan Düşük Olamaz.");
            RuleFor(x => x.Stok).NotEmpty().WithMessage("Stok Adedi Boş Geçilemez.");
            RuleFor(x => x.Fiyat).GreaterThan(0).WithMessage("Fiyat 0 dan Düşük Olamaz.");
            RuleFor(x => x.Fiyat).NotEmpty().WithMessage("Fiyat Boş Geçilemez.");
            RuleFor(x => x.BarkodNo).NotEmpty().WithMessage("BarKOD No Boş Geçilemez.");
            RuleFor(x => x.BarkodNo).MaximumLength(150).WithMessage("BarKOD No Boş Geçilemez.");








        }
    }
}
