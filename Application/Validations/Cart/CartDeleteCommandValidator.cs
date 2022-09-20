using Application.Commands.Cart;
using FluentValidation;

namespace Application.Validations.Cart
{
    internal class CartDeleteCommandValidator : AbstractValidator<CartDeleteCommand>
    {
        public CartDeleteCommandValidator()
        {
            RuleFor(x => x.ItemId)
                   .NotEmpty().WithMessage("ItemId is required.")
                   .GreaterThan(0);
        }
    }
}
