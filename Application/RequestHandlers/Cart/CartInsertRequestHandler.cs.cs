using Application.Commands.Cart;
using Application.Persistence.Managers;
using Application.Responses.Cart;
using AutoMapper;
using MediatR;

namespace Application.RequestHandlers.Cart
{
    public class CartInsertRequestHandler : IRequestHandler<CartInsertCommand, CartResponse>
    {
        public ICartsManager _cartsManager;
        public IMapper _mapper;

        public CartInsertRequestHandler(ICartsManager cartsManager, IMapper mapper)
        {
            _cartsManager = cartsManager;
            _mapper = mapper;
        }

        public async Task<CartResponse> Handle(CartInsertCommand command, CancellationToken cancellationToken)
        {
            var cart = _mapper.Map<Domain.Models.Cart>(command);
            var res = await _cartsManager.AddItemToCart(cart);
            return _mapper.Map<CartResponse>(res);
        }
    }
}
