using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistence.Managers
{
    public interface ICartsManager
    {
        Task<Cart> AddItemToCart(Cart cart);
        Task<bool> RemoveItemFromCart(int itemId);
        Task<double> GetPrice();
        Task<double> GetPriceWithDiscount();
        Task<List<Cart>> OrderItem();
    }
}
