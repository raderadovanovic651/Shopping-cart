using Application.Commands.Item;
using Application.Persistence.Managers;
using Application.Responses.Item;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RequestHandlers.Item
{
    public class ItemInsertRequestHandler : IRequestHandler<ItemInsertCommand, ItemResponse>
    {
        public IItemsManager _itemsManager;
        public IMapper _mapper;

        public ItemInsertRequestHandler(IItemsManager itemsManager, IMapper mapper)
        {
            _itemsManager = itemsManager;
            _mapper = mapper;
        }

        public async Task<ItemResponse> Handle(ItemInsertCommand command, CancellationToken cancellationToken)
        {
            var item = _mapper.Map<Domain.Models.Item>(command);
            var res = await _itemsManager.SaveItem(item);
            return _mapper.Map<ItemResponse>(res);
        }
    }
}
