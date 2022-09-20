using MediatR;

namespace Application.Queries.Item
{
    public class GetItemDiscountQuery : IRequest<double>
    {
        public int ItemId;
    }
}
