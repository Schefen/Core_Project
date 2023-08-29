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
            RuleFor(x => x.ExperienceName).NotEmpty().WithMessage("Lütfen Boşluğu Doldurunuz.");
            RuleFor(x => x.ExperienceDate).NotEmpty().WithMessage("Lütfen Boşluğu Doldurunuz.");
            RuleFor(x => x.ExperienceImageUrl).NotEmpty().WithMessage("Lütfen Boşluğu Doldurunuz.");
            RuleFor(x => x.ExperienceDescription).NotEmpty().WithMessage("Lütfen Boşluğu Doldurunuz.");
        }
    }
}
