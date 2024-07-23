using FluentValidation;
using MVC_MagazaOnline.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Validations
{
    public class KullaniciRolleriValidator:AbstractValidator<KullaniciRolleri>
    {
        public KullaniciRolleriValidator()
        {
            RuleFor(x => x.RolId).NotEmpty().WithMessage("Roll ID Boş Geçilemez.");
            
        }
    }
}
