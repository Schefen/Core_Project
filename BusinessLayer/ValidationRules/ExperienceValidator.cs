using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ExperienceValidator : AbstractValidator<Experience>
    {
        public ExperienceValidator()
        {
            RuleFor(x => x.ExperienceName).NotNull().WithMessage("Lütfen Eklenecek Yetenek Giriniz.");
            RuleFor(x => x.ExperienceDate).NotNull().WithMessage("Lütfen Eklenecek Değeri Giriniz.");
            RuleFor(x => x.ExperienceImageUrl).NotNull().WithMessage("Lütfen Eklenecek Değeri Giriniz.");
            RuleFor(x => x.ExperienceDescription).NotNull().WithMessage("Lütfen Eklenecek Değeri Giriniz.");
        }
    }
}
