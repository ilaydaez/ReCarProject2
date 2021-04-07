using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator: AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage("Müşteriye ait kullanıcı nmarasını giriniz!!");
            RuleFor(c => c.CompanyName).NotEmpty().WithMessage("Müşteriye ait şehiri giriniz!!");
        }
    }
}
