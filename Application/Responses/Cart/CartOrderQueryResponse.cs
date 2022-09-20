using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Responses.Cart
{
    public class CartOrderQueryResponse
    {
        public virtual List<Domain.Models.Item> Items { get; set; }
        public double Total { get; set; }
    }
}
