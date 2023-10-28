using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen rehber adını giriniz");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Lütfen 100 karakterden daha kısa bir isim giriniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen açıklamayı giriniz");
            RuleFor(x => x.ImageURL).NotEmpty().WithMessage("Lütfen rehber görseli ekleyiniz");
        }
    }
}
