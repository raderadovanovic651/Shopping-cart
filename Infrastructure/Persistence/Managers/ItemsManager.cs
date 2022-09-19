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
    public class ItemsManager : IItemsManager
    {
        private readonly IShoppingCartUow _shoppingCartUow;

        public ItemsManager(IShoppingCartUow shoppingCartUow)
        {
            _shoppingCartUow = shoppingCartUow;
        }

        public Task<List<Item>> GetAllItems()
        {
            return _shoppingCartUow.ItemsRepository.GetAllItems();
        }

        public Item GetItemById(int id)
        {
            return _shoppingCartUow.ItemsRepository.GetItemById(id);
        }

        public async Task<Item> SaveItem(Item item)
        {
            var result = _shoppingCartUow.ItemsRepository.SaveItem(item);
            var res = await _shoppingCartUow.SaveChanges();
            if (!res)
            {
                throw new Exception();
            }
            else 
                return result;
        }
        public async Task<bool> DeleteItem(Item item)
        {
            var result = _shoppingCartUow.ItemsRepository.DeleteItem(item);
            return await _shoppingCartUow.SaveChanges();
        }
    }
}
