using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SkillValidator : AbstractValidator<Skill>
    {
        public SkillValidator()
        {
            RuleFor(x => x.SkillTitle).NotNull().WithMessage("Lütfen Eklenecek Yetenek giriniz.");
            RuleFor(x => x.SkillValue).NotNull().WithMessage("Lütfen Eklenecek Değeri Giriniz giriniz.");
        }
    }
}
