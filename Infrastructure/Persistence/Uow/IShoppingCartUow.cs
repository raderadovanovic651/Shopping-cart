using Infrastructure.Persistence.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Uow
{
    public interface IShoppingCartUow
    {
        IItemsRepository ItemsRepository { get; }
        Task<bool> SaveChanges();
    }
}
