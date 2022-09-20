using Application.Responses.Cart;
using MediatR;

namespace Application.Queries.Cart
{
    public class CartOrderQuery : IRequest<CartOrderQueryResponse>
    {
    }
}
