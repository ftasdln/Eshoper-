using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PictureValidator:AbstractValidator<Pictures>
    {
        public PictureValidator()
        {
            RuleFor(x=>x.PictureUrl).NotEmpty().WithMessage("Resim Adresi Boş Bırakılamaz");
           
            
        }
    }
}
