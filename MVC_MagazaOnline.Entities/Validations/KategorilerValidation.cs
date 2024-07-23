using FluentValidation;
using MVC_MagazaOnline.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Validations
{
    public class KategorilerValidation:AbstractValidator<Kategoriler>
    {
        public KategorilerValidation()
        {
            RuleFor(x=>x.KiyafetKategori).NotEmpty().WithMessage("Kıyafet Kategorisi Boş Geçilemez.");
            RuleFor(x=>x.KiyafetKategori).Length(3,50).WithMessage("Kıyafet Kategorisi 3 ve 50 Karakter Arasında Olmaladır.");
            RuleFor(x=>x.Aciklama).NotEmpty().WithMessage("Kıyafet Açıklama Boş Geçilemez.");
            RuleFor(x => x.Aciklama).Length(5,500).WithMessage("Kıyafet Açıklama 5 ve 500 Karakter Arasında Olmalıdır.");


        }
    }
}
