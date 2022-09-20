﻿using Application.Responses.Cart;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Cart
{
    public class CartInsertCommand : IRequest<CartResponse>
    {
        public int ItemId { get; set; }

    }
}
