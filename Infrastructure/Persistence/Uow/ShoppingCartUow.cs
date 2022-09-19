using Infrastructure.Persistence.Repositories.Implementatios;
using Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Uow
{
    public class ShoppingCartUow : IShoppingCartUow
    {
        protected ShoppingCartContext _dbContext;

        public ShoppingCartUow(ShoppingCartContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IItemsRepository ItemsRepository => new ItemsRepository(_dbContext);

        public async Task<bool> SaveChanges()
        {
            return await _dbContext.SaveChangesAsync() > 0; 
        }
    }
}
