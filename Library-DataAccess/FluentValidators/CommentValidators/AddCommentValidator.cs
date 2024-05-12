using FluentValidation;
using Library_Core.DTO_s.CommentDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccess.FluentValidators.CommentValidators
{
    public class AddCommentValidator : AbstractValidator<AddCommentDTO>
    {
        public AddCommentValidator()
        {
            RuleFor(x => x.UserComment)
            .NotEmpty().WithMessage("UserComment is required.")
            .Length(1, 500).WithMessage("UserComment must be between 1 and 500 characters.");

        }
    }
}
