using Application.Commands.Cart;
using Application.Persistence.Managers;
using Application.Queries.Cart;
using Application.Responses.Cart;
using AutoMapper;
using MediatR;

namespace Application.RequestHandlers.Cart
{
    public class CartGetPriceRequestHandler : IRequestHandler<CartGetPriceQuery, double>
    {
        public ICartsManager _cartsManager;
        public IMapper _mapper;

        public CartGetPriceRequestHandler(ICartsManager cartsManager, IMapper mapper)
        {
            _cartsManager = cartsManager;
            _mapper = mapper;
        }

        public async Task<double> Handle(CartGetPriceQuery query, CancellationToken cancellationToken)
        {
             return await _cartsManager.GetPrice();
        }
    }
}