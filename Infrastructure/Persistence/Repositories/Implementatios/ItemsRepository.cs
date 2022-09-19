using Domain.Models;
using Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Implementatios
{
    public class ItemsRepository : IItemsRepository
    {
        protected ShoppingCartContext _dbContext;
        public ItemsRepository(ShoppingCartContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<List<Item>> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Item GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public Item SaveItem(Item item)
        {
            _dbContext.Items.Add(item);
            return item;
        }
        public bool DeleteItem(Item item)
        {
            throw new NotImplementedException();
        }

    }
}
