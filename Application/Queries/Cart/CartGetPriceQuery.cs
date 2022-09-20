using MediatR;

namespace Application.Queries.Cart
{
    public class CartGetPriceQuery : IRequest<double>
    {
    }
}
