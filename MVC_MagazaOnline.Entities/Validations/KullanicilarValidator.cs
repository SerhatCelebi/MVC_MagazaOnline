using FluentValidation;
using MVC_MagazaOnline.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MagazaOnline.Entities.Validations
{
    public class KullanicilarValidator:AbstractValidator<Kullanicilar>
    {
        public KullanicilarValidator()
        {
            RuleFor(x=>x.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı ID Boş Geçilemez.");
            RuleFor(x => x.KullaniciAdi).Length(5,30).WithMessage("Kullanıcı ID 5 ve 30 Karakter Arasında Olmalıdır.");
            
            RuleFor(x => x.Sifre).NotEmpty().WithMessage("Kullanıcı Şifre Boş Geçilemez.");
            RuleFor(x => x.Sifre).Length(5, 30).WithMessage("Kullanıcı Şifre 5 ve 30 Karakter Arasında Olmalıdır.");


            RuleFor(x => x.Email).NotEmpty().WithMessage("Kullanıcı Emaili Boş Geçilemez.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Kullanıcı Emalini Geçerli Formata Göre Yazınız.");
            RuleFor(x => x.Email).MaximumLength(50).WithMessage("Kullanıcı Emalini En Fazla 50 Karakter Alabilir.");

            RuleFor(x => x.AdSoyad).NotEmpty().WithMessage("Kullanıcı Adı ve Soy Adı Boş Geçilemez.");
            RuleFor(x => x.AdSoyad).MaximumLength(100).WithMessage("Kullanıcı Adı ve Soy Adı En Fazla 100 Karakter Girilebilir.");

            RuleFor(x => x.Adres).NotEmpty().WithMessage("Kullanıcı Adresi Boş Geçilemez.");
            RuleFor(x => x.Adres).MaximumLength(500).WithMessage("Kullanıcı Adresi En Fazla 500 Karakter Girilebilir.");

            RuleFor(x => x.Telefon).NotEmpty().WithMessage("Kullanıcı Telefonu Boş Geçilemez.");
            RuleFor(x => x.Telefon).MaximumLength(20).WithMessage("Kullanıcı Telefonu En Fazla 20 Karakter Girilebilir.");






        }
    }
}
