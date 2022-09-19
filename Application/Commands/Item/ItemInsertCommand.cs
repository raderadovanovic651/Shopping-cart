using Application.Responses.Item;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Item
{
    public class ItemInsertCommand : IRequest<ItemResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
