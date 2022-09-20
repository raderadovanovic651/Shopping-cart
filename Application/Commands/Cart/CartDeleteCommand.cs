using Application.Responses.Cart;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Cart
{
    public class CartDeleteCommand : IRequest<bool>
    {
        public int ItemId { get; set; }
    }
}
