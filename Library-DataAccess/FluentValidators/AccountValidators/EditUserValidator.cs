using FluentValidation;
using Library_Core.DTO_s.AccountDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccess.FluentValidators.AccountValidators
{
    public class EditUserValidator : AbstractValidator<EditUserDTO>
    {
        public EditUserValidator()
        {

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("E-Mail alanı boş geçilemez!")
                .EmailAddress()
                .WithMessage("E-Mail formatında giriş yapınız!");
        }
    }
}
