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
        public List<Item> GetAllItems()
        {
            return _dbContext.Items.ToList();
        }

        public Item GetItemById(int id)
        {
            return _dbContext.Items.Where(x => x.Id == id).FirstOrDefault();
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
