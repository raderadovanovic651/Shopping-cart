using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistence.Managers
{
    public interface IItemsManager
    {
        Task<List<Item>> GetAllItems();
        Item GetItemById(int id);
        Task<Item> SaveItem(Item item);
        Task<bool> DeleteItem(Item item);
    }
}
