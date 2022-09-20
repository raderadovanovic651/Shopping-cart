using Application.Commands.Item;
using FluentValidation;


namespace Application.Validations.Item
{
    public class ItemInsertCommandValidator : AbstractValidator<ItemInsertCommand>
    {
        public ItemInsertCommandValidator()
        {
            RuleFor(x => x.Name)
                   .NotEmpty().WithMessage("Name is required.");
            RuleFor(x => x.Price)
                   .NotEmpty().WithMessage("Price is required.")
                   .GreaterThan(0.0).WithMessage("Price must have positive value.");
            RuleFor(x => x.Discount)
                   .GreaterThanOrEqualTo(0.0).WithMessage("Discount must have positive value.");
        }
    }
}
