using Domain.Models;
using Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Implementatios
{
    public class CartRepository : ICartRepository
    {
        protected ShoppingCartContext _dbContext;
        public CartRepository(ShoppingCartContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Cart AddItemToCart(Cart cart)
        {
            return _dbContext.Carts.Add(cart).Entity;
        }

        public Cart UpdateCart(Cart cart)
        {
            return _dbContext.Carts.Update(cart).Entity;
        }

        public void RemoveItemFromCart(int itemId)
        {
            var item = _dbContext.Carts.Where(x => x.ItemId == itemId && x.IsPaid == false).FirstOrDefault();
            if (item != null)
            {
                _dbContext.Carts.Remove(item);
            }
        }

        public async Task<List<Cart>> GetCartItems()
        {
            return await _dbContext.Carts.Include(i => i.Item).Where(x => x.IsPaid == false).ToListAsync();
        }
    }
}
