using FluentValidation;
using MVC_MagazaOnline.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Validations
{
    public class RollerValidator:AbstractValidator<Roller>
    {
        public RollerValidator()
        {
            RuleFor(x => x.Rol).NotEmpty().WithMessage("Roll Boş Geçilemez.");
            RuleFor(x => x.Rol).MaximumLength(50).WithMessage("Roll En Fazla 50 Karakter Olmalıdır.");
        }
    }
}
