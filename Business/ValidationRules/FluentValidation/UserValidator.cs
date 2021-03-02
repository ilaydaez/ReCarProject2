using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserFirstName).NotEmpty().WithMessage("Kullanıcı adı boş bırakılamaz!!");
            RuleFor(u => u.UserFirstName).MinimumLength(2).WithMessage("Kullanıcı adı 2 karakterden küçük olamaz!!");
            RuleFor(u => u.UserLastName).NotEmpty().WithMessage("Kullanıcı soyadı boş bırakılmaz!!");
            RuleFor(u => u.UserLastName).MinimumLength(2).WithMessage("Kullanıcı soyadı 2 karakterden küçük olamaz!!");
            //RuleFor(u => u.Password).NotEmpty().WithMessage("Lütfen şifrenizi giriniz!!");
            //RuleFor(u => u.Password).Must(PasswordLength).WithMessage("Şifre 8 Karakterli Olmalıdır.");
            RuleFor(u => u.Email).EmailAddress().When(u => !string.IsNullOrEmpty(u.Email)).WithMessage("Lütfen geçerli bir mail adresi giriniz!!");
        }

        private bool PasswordLength(int arg)
        {
            return arg.ToString().Length == 8;   
        }
    }
}
