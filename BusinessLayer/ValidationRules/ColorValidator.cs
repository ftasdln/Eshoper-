using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ColorValidator : AbstractValidator<Colors>
    {
        public ColorValidator()
        {
            RuleFor(x=>x.ColorName).NotEmpty().WithMessage("Resim Rengi Boş Bırakılamaz");
            
        }
    }
}
