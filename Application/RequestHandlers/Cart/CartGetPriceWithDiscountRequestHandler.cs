using Application.Persistence.Managers;
using Application.Queries.Cart;
using AutoMapper;
using MediatR;

namespace Application.RequestHandlers.Cart
{
    public class CartGetPriceWithDiscountRequestHandler : IRequestHandler<CartGetPriceWithDiscontQuery, double>
    {
        public ICartsManager _cartsManager;
        public IMapper _mapper;

        public CartGetPriceWithDiscountRequestHandler(ICartsManager cartsManager, IMapper mapper)
        {
            _cartsManager = cartsManager;
            _mapper = mapper;
        }

        public async Task<double> Handle(CartGetPriceWithDiscontQuery query, CancellationToken cancellationToken)
        {
            return await _cartsManager.GetPriceWithDiscount();
        }
    }
}
