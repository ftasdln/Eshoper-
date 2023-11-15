using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CommentValidator : AbstractValidator<Comments>
    {
        public CommentValidator()
        {
            RuleFor(x=>x.CommentText).NotEmpty().WithMessage("Yorum Boş Bırakılamaz");
            RuleFor(x=>x.Commenter).NotEmpty().WithMessage("Yazar Boş Bırakılamaz");
        }
    }
}
