using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator: AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CustomerID).NotEmpty().WithMessage("Müşteri numarası boş bırakılamaz!!");
            RuleFor(r => r.RentDate).NotEmpty().WithMessage("Kiralanma tarihi boş bırakılamaz!!");
            RuleFor(r => r.ReturnDate).GreaterThanOrEqualTo(r => r.RentDate).WithMessage("Geri dönüş tarihi kiralanma tarihinden önce olamaz!!");

        }

        
    }
}
