using DTOLayer.DTOs.AnnouncementDTO_s;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator:AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık kısmı boş geçilemez");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Duyuru içerği boş geçilemez");

            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Duyuru içeriği en az 20 karakter olmalıdır");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Duyuru içeriği en az 500 karakter olmalıdır");
        }
    }
}
