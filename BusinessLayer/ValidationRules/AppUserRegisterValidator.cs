using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
public    class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim Alanı Boş Geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Alanı Boş Geçilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Lütfen minimum 5 karakterlik veri girişi yapınız");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen maximum 30 karakterlik veri girişi yapınız");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler uyumlu değil");
        }
    }
}
