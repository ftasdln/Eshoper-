using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün İsmi Boş Bırakılamaz");
            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün Açıklaması Boş Bırakılamaz");
            RuleFor(x => x.ProductFeature).NotEmpty().WithMessage("Ürün Özellikleri Boş Bırakılamaz");
            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("Ürün Fiyatı Boş Bırakılamaz");
            
        }
    }
}
