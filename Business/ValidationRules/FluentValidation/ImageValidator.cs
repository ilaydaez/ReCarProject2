using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(ı => ı.CarID).NotEmpty().WithMessage("Fotoğrafa ait araç numarası boş bırakılamaz");
            RuleFor(ı => ı.ImagePath).NotEmpty();
            RuleFor(ı => ı.ImagePath).NotNull();
        }
    }
}
