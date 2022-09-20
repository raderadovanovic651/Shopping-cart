using Application.Commands.Cart;
using FluentValidation;

namespace Application.Validations.Cart
{
    public class CartInsertCommandValidator : AbstractValidator<CartInsertCommand>
    {
        public CartInsertCommandValidator()
        {
            RuleFor(x => x.ItemId)
                   .NotEmpty().WithMessage("ItemId is required.")
                   .GreaterThan(0);
        }
    }
}
