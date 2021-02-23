using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty().WithMessage("Araç adı boş bırakılamaz!!");
            RuleFor(c => c.CarName).MinimumLength(3).WithMessage("Araç adı 3 karakterden küçük olamaz!!");
            RuleFor(c => c.BrandID).NotEmpty().WithMessage("Araca ait modeli giriniz!!");
            RuleFor(c => c.ColorID).NotEmpty().WithMessage("Araca ait renk özelliğini giriniz!!");
            
            
        }
    }
}
