using FluentValidation;
using Library_Core.DTO_s.BookDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccess.FluentValidators.BookValidators
{
    public class AddBookValidator : AbstractValidator<AddBookDTO>
    {
        public AddBookValidator()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("Name is required.")
           .Length(1, 100).WithMessage("Name must be between 1 and 100 characters.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Description is required.")
                .Length(1, 500).WithMessage("Description must be between 1 and 500 characters.");

            RuleFor(x => x.Author.Name )
                .NotEmpty().WithMessage("Author name is required.")
           .Length(1, 100).WithMessage("Name must be between 1 and 100 characters.");

            RuleFor(x => x.Genre.Name)
                .NotEmpty().WithMessage("Genre name is required.")
           .Length(1, 100).WithMessage("Name must be between 1 and 100 characters.");

            RuleFor(x => x.PageCount)
                .NotEmpty().WithMessage("PageCount is required.")
                .GreaterThan(0).WithMessage("PageCount must be greater than 0.");

            RuleFor(x => x.PublishYear)
                .NotEmpty().WithMessage("PublishYear is required.")
                .InclusiveBetween(1450, DateTime.Now.Year).WithMessage("PublishYear must be between 1450 and the current year.");

            RuleFor(x => x.Publisher.Name)
                .NotEmpty().WithMessage("Publisher name is required.")
           .Length(1, 100).WithMessage("Name must be between 1 and 100 characters.");

            RuleFor(x => x.StockCount)
                .NotEmpty().WithMessage("StockCount is required.")
                .GreaterThan(0).WithMessage("StockCount must be greater than 0.");

            RuleFor(x => x.Language)
                .NotEmpty().WithMessage("Language is required.")
                .Length(1, 50).WithMessage("Language must be between 1 and 50 characters.");

            RuleFor(x => x.ImageUrl)
                .NotEmpty().WithMessage("ImageUrl is required.")
                .Length(1, 500).WithMessage("ImageUrl must be between 1 and 500 characters.");
        }
    }
}
