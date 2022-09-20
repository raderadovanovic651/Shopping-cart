using Infrastructure.Persistence.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Uow
{
    public interface ICartUow
    {
        ICartRepository CartRepository { get; }
        Task<bool> SaveChanges();
    }

}
