using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Responses.Cart
{
    public class CartResponse
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public bool isPaid { get; set; }
    }
}
