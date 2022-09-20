using Application.Commands.Cart;
using Application.Persistence.Managers;
using Application.Queries.Cart;
using Application.Responses.Cart;
using AutoMapper;
using MediatR;

namespace Application.RequestHandlers.Cart
{
    internal class CartOrderRequestHandler : IRequestHandler<CartOrderQuery, CartOrderQueryResponse>
    {
        public ICartsManager _cartsManager;
        public IMapper _mapper;

        public CartOrderRequestHandler(ICartsManager cartsManager, IMapper mapper)
        {
            _cartsManager = cartsManager;
            _mapper = mapper;
        }

        public async Task<CartOrderQueryResponse> Handle(CartOrderQuery command, CancellationToken cancellationToken)
        {
            var res = await _cartsManager.OrderItem();
            var carts = _mapper.Map<List<Domain.Models.Cart>>(res);
            CartOrderQueryResponse response = new CartOrderQueryResponse { Items = new List<Domain.Models.Item>()};
            foreach (var cart in carts)
            {
                response.Total += cart.Item.Price - cart.Item.Discount;
                response.Items.Add(cart.Item);
            }
            return response;
        }
    }
}
