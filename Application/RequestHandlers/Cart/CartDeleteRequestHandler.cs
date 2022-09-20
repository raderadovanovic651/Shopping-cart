using Application.Commands.Cart;
using Application.Persistence.Managers;
using Application.Responses.Cart;
using AutoMapper;
using MediatR;

namespace Application.RequestHandlers.Cart
{
    public class CartDeleteRequestHandler : IRequestHandler<CartDeleteCommand, bool>
    {
        public ICartsManager _cartsManager;
        public IMapper _mapper;

        public CartDeleteRequestHandler(ICartsManager cartsManager, IMapper mapper)
        {
            _cartsManager = cartsManager;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CartDeleteCommand command, CancellationToken cancellationToken)
        {
            return await _cartsManager.RemoveItemFromCart(command.ItemId);
        }
    }
}
