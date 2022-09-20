using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Interfaces
{
    public interface ICartRepository
    {
        Cart AddItemToCart(Cart cart);
        void RemoveItemFromCart(int itemId);
        Cart UpdateCart(Cart cart);
        Task<List<Cart>> GetCartItems();
    }
}
