using Application.Commands.Item;
using Application.Persistence.Managers;
using Application.Queries.Item;
using Application.Responses.Item;
using AutoMapper;
using MediatR;

namespace Application.RequestHandlers.Item
{
    internal class ItemDiscountQueryRequestHandler : IRequestHandler<GetItemDiscountQuery, double>
    {
        public IItemsManager _itemsManager;
        public IMapper _mapper;

        public ItemDiscountQueryRequestHandler(IItemsManager itemsManager, IMapper mapper)
        {
            _itemsManager = itemsManager;
            _mapper = mapper;
        }

        public async Task<double> Handle(GetItemDiscountQuery query, CancellationToken cancellationToken)
        {
            var res =  _itemsManager.GetItemById(query.ItemId);
            if (res != null)
            {
                return res.Discount;
            }
            else 
                return 0;
        }
    }
}
