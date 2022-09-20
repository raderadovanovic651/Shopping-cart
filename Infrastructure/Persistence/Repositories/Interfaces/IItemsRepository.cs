﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IItemsRepository
    {
        Item GetItemById(int id);
        Item SaveItem(Item item);
    }
}
