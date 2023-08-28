using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ServiceValidator : AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            RuleFor(x => x.ServiceTitle).NotEmpty().WithMessage("Lütfen Hizmet Adı Giriniz.");
            RuleFor(x => x.ServiceImageUrl).NotEmpty().WithMessage("Lütfen Fotoğraf Yolu Giriniz.");
        }
    }
}
