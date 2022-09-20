using Application.Persistence.Managers;
using Domain.Models;
using Infrastructure.Persistence.Uow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Managers
{
    public class CartsManager : ICartsManager
    {
        private readonly IShoppingCartUow _shoppingCartUow;

        public CartsManager(IShoppingCartUow shoppingCartUow)
        {
            _shoppingCartUow = shoppingCartUow;
        }

        public async Task<Cart> AddItemToCart(Cart cart)
        {
            cart.IsPaid = false;
            var result = _shoppingCartUow.CartRepository.AddItemToCart(cart);
            var res = await _shoppingCartUow.SaveChanges();
            if (!res)
            {
                throw new Exception();
            }
            else
                return result;
        }

        public async Task<double> GetPrice()
        {
            var cartItems = await _shoppingCartUow.CartRepository.GetCartItems();
            double total = 0;
            if (cartItems.Any())
            {
                foreach (var cartItem in cartItems)
                {
                    if (cartItem.Item != null)
                    {
                        total += cartItem.Item.Price;
                    }
                }
            }
            return total;
        }

        public async Task<double> GetPriceWithDiscount()
        {
            var cartItems = await _shoppingCartUow.CartRepository.GetCartItems();
            double total = 0;
            if (cartItems.Any())
            {
                foreach (var cartItem in cartItems)
                {
                    
                    if (cartItem.Item != null)
                    {
                        total += cartItem.Item.Price - cartItem.Item.Discount;
                    }
                }
            }
            return total;
        }

        public async Task<List<Cart>> OrderItem()
        {
            var cartItems = await _shoppingCartUow.CartRepository.GetCartItems();
            foreach(var cartItem in cartItems)
            {
                cartItem.IsPaid = true;
                _shoppingCartUow.CartRepository.UpdateCart(cartItem);
            }
            await _shoppingCartUow.SaveChanges();
            return cartItems;
        }

        public async Task<bool> RemoveItemFromCart(int itemId)
        {
            _shoppingCartUow.CartRepository.RemoveItemFromCart(itemId);
            var isSuccessfull = await _shoppingCartUow.SaveChanges();
            if (isSuccessfull)
            {
                return true;
            }
            else 
                return false;
        }
    }
}
