using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.PortfolioName).NotEmpty().WithMessage("Lütfen Proje Adı giriniz.");  
            RuleFor(x => x.PortfolioImageUrl).NotEmpty().WithMessage("Lütfen Küçük Resim giriniz.");  
            RuleFor(x => x.PortfolioImageUrl2).NotEmpty().WithMessage("Lütfen Büyük Resim giriniz.");  
            RuleFor(x => x.PortfolioUrl).NotEmpty().WithMessage("Lütfen Proje URL giriniz.");  
        }
    }
}
