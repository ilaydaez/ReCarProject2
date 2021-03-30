using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class PaymentValidator : AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(p => p.CardNameSurname).NotEmpty().WithMessage("Ödeme için NameSurname Değeri Boş Olamaz.");
            RuleFor(p => p.CardNameSurname).MinimumLength(5).WithMessage("Ödeme için NameSurname Değeri 5 Karakterden Büyük Olmalı.");
            RuleFor(p => p.CardNumber).NotEmpty().WithMessage("Ödeme için CardNumber Değeri Boş Olamaz.");
            RuleFor(p => p.CardNumber).Length(12).WithMessage("Ödeme için CardNumber Değeri 12 karakter olmalı");
            RuleFor(p => p.CardExpiryDate).NotEmpty().WithMessage("Ödeme için ExpiryDate Değeri Boş Olamaz.");
            RuleFor(p => p.CardExpiryDate).MinimumLength(2).WithMessage("Ödeme için ExpiryDate Değeri 2 Karakterden Büyük Olmalı.");
            RuleFor(p => p.CardCvv).NotEmpty().WithMessage("Ödeme için Cvv Değeri Boş Olamaz.");
            RuleFor(p => p.CardCvv).Length(3).WithMessage("Ödeme için Cvv Değeri 3 karakter olmalı.");
        }
    }
}
